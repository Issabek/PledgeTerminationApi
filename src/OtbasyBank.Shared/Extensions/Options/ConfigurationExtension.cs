using Microsoft.Extensions.Configuration;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace OtbasyBank.Shared.Extensions.Options;

public static class ConfigurationExtension
{
    private static readonly Assembly SystemAssembly = typeof(object).Assembly;

    /// <summary>
    ///     get the valid options.
    /// </summary>
    /// <typeparam name="TOptions">target configuration</typeparam>
    /// <param name="configuration">configuration file</param>
    /// <param name="sectionName">section name</param>
    /// <returns></returns>
    public static TOptions GetValidOptions<TOptions>(this IConfiguration configuration, string sectionName)
        where TOptions : class
    {
        if (configuration is null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        if (sectionName is null)
        {
            throw new ArgumentNullException(nameof(sectionName));
        }

        var section = configuration.GetSection(sectionName);
        if (!section.HasItems())
        {
            throw new InvalidOperationException($"There is no key-value(s) in the section {sectionName}");
        }

        var options = section.ImmutableBind<TOptions>();
        if (options is null)
        {
            throw new InvalidOperationException($"Unable to build {typeof(TOptions).Name}");
        }

        if (!DataAnnotationsValidator.TryValidate(options, out var validationResults))
        {
            var validationExceptions = validationResults.Select(x => new ValidationException(x.ErrorMessage));
            var aggregatedException = new AggregateException(validationExceptions);

            throw new InvalidOperationException($"Unable to build {typeof(TOptions).Name}", aggregatedException);
        }

        return options;
    }

    /// <summary>
    ///     Returns true, if configuration has key-values.
    /// </summary>
    /// <param name="configuration">The configuration.</param>
    /// <returns>True or False.</returns>
    public static bool HasItems(this IConfiguration configuration)
    {
        var configs = configuration.AsEnumerable().ToList();
        return configs.Count is not (0 or 1);
    }

    /// <summary>
    ///     Attempts to bind the configuration instance to a new instance of type <typeparamref name="T" />.
    ///     If this configuration section has a value, that will be used.
    ///     Otherwise binding by matching constructor arguments against configuration keys recursively.
    /// </summary>
    /// <typeparam name="T">
    ///     The type of the new instance to bind.
    /// </typeparam>
    /// <param name="configuration">
    ///     The configuration instance to bind.
    /// </param>
    /// <returns>
    ///     The new instance of <typeparamref name="T" />.
    /// </returns>
    /// <exception cref="ArgumentNullException">
    ///     If <paramref name="configuration" /> is <see langword="null" />.
    /// </exception>
    /// <exception cref="InvalidOperationException">
    ///     If binding of the <paramref name="configuration" /> failed due to any reason.
    /// </exception>
    public static T? ImmutableBind<T>(this IConfiguration configuration)
        where T : class
    {
        if (configuration is null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        return (T?)BindType(typeof(T), configuration);
    }

    private static object? BindType(Type type, IConfiguration config)
    {
        var section = config as IConfigurationSection;
        var configValue = section?.Value;

        if (configValue != null &&
            type.TryConvertValue(configValue, out var convertedValue, out var error))
        {
            if (error != null) throw error;

            return convertedValue;
        }

        var dictionaryInterface = type.FindOpenGenericInterface(typeof(IReadOnlyDictionary<,>));
        if (dictionaryInterface != null)
        {
            return BindDictionary(type, config);
        }

        var collectionInterface = type.FindOpenGenericInterface(typeof(IReadOnlyCollection<>))
                                  ?? type.FindOpenGenericInterface(typeof(IReadOnlyList<>));
        if (collectionInterface != null)
        {
            return BindCollection(type, config);
        }

        if (IsSystemType(type))
        {
            return null;
        }

        var constructors = type.GetConstructors();
        if (constructors.Length > 1)
        {
            throw new InvalidOperationException($"{type.Name} must contain only one constructor with parameters");
        }

        // For the first version, just take the first constructor.
        var constructor = constructors.Single();
        var values = new List<object?>();

        foreach (var parameter in constructor.GetParameters())
        {
            var value = BindType(parameter.ParameterType, config.GetSection(parameter.Name)) ?? default;
            values.Add(value);
        }

        var instance = constructor.Invoke(values.ToArray());

        return instance;
    }

    private static object? BindCollection(Type type, IConfiguration config)
    {
        if (!config.GetChildren().Any())
        {
            return null;
        }

        var elementType = type.GetGenericArguments()[0];
        var collectionType = typeof(Collection<>).MakeGenericType(elementType);
        var collectionAddMethod = collectionType.GetMethod("Add");

        var collectionInstance = Activator.CreateInstance(collectionType);
        foreach (var section in config.GetChildren())
        {
            var element = BindType(elementType, section);
            collectionAddMethod?.Invoke(collectionInstance, new[] { element });
        }

        var readOnlyCollectionType = typeof(ReadOnlyCollection<>).MakeGenericType(elementType);
        var readOnlyCollectionInstance = Activator.CreateInstance(readOnlyCollectionType, collectionInstance);

        return readOnlyCollectionInstance;
    }

    private static object? BindDictionary(Type type, IConfiguration config)
    {
        if (!config.GetChildren().Any())
        {
            return null;
        }

        var keyType = type.GetGenericArguments()[0];
        var elementType = type.GetGenericArguments()[1];
        var dictionaryType = typeof(Dictionary<,>).MakeGenericType(keyType, elementType);
        var dictionaryAddMethod = dictionaryType.GetMethod("Add");

        var dictionaryInstance = Activator.CreateInstance(dictionaryType);
        foreach (var section in config.GetChildren())
        {
            if (!keyType.TryConvertValue(section.Key, out var convertedKeyValue, out var error))
                if (error != null)
                    throw error;

            var element = BindType(elementType, section);
            dictionaryAddMethod?.Invoke(dictionaryInstance, new[] { convertedKeyValue, element });
        }

        var readOnlyDictionaryType = typeof(ReadOnlyDictionary<,>).MakeGenericType(keyType, elementType);
        var readOnlyDictionaryInstance = Activator.CreateInstance(readOnlyDictionaryType, dictionaryInstance);

        return readOnlyDictionaryInstance;
    }

    private static bool IsSystemType(this Type type)
    {
        return type.Assembly == SystemAssembly;
    }
}
