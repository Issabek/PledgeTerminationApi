using Serilog;
using Serilog.Events;
using Newtonsoft.Json.Converters;
using OtbasyBank.Application;
using OtbasyBank.Infrastructure;
using OtbasyBank.SelfHost.Features.Options;
using OtbasyBank.SelfHost.Features.Filters;
using OtbasyBank.SelfHost.Features.Swagger;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using OtbasyBank.SelfHost.Features.AutoMapper;
using OtbasyBank.SelfHost.Features.DeveloperMode;
using OtbasyBank.SelfHost.Features.ApiVersioning;
using OtbasyBank.Shared.Extensions.Serilog;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

Log.Logger = new SerilogLoggerConfiguration(configuration).LogConfs(builder.Environment);
builder.Host.UseSerilog();


var options = new OtbasyBankOptions(
        configuration.GetValue<string>($"{OtbasyBankOptions.SectionName}:{nameof(OtbasyBankOptions.InstanceName)}"),
        configuration.GetValue<string>($"{OtbasyBankOptions.SectionName}:{nameof(OtbasyBankOptions.WebAddress)}")
    );

try
{
    Log.Information("Configuring web host ({ApplicationName})...", options.InstanceName);
    builder.WebHost.UseUrls(options.WebAddress);
    builder.WebHost.ConfigureLogging(options => options.AddSerilog());
    builder.Services.AddControllers(options => { options.Filters.Add<HttpGlobalExceptionFilter>(); })
                    .AddNewtonsoftJson(options =>
                    {
                        options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    });
    builder.Services.AddSwagger();
    builder.Services.AddVersioning();
    builder.Services.AddAutoMapper();
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure(configuration);
    builder.Services.AddLocalization(options => options.ResourcesPath = "");

    var app = builder.Build();
    var apiVersionProvider = builder.Services.BuildServiceProvider()
        .GetRequiredService<IApiVersionDescriptionProvider>();
        app.UseDeveloperMode(apiVersionProvider);
    app.UseHttpsRedirection();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();
    Log.Information("Starting web host ({ApplicationName})...", options.InstanceName);
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Program terminated unexpectedly ({ApplicationName})!", options.InstanceName);
}
finally
{
    Log.CloseAndFlush();
}