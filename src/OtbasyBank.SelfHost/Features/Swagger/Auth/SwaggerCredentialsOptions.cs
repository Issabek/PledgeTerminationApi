namespace OtbasyBank.SelfHost.Features.Swagger.Auth;

/// <summary>
/// Swagger credential options
/// </summary>
public class SwaggerCredentialsOptions
{
	/// <summary>
	/// Section name in appsettings json
	/// </summary>
	public const string SectionName = "SwaggerCredentials";

	/// <summary>
	/// User name field
	/// </summary>
	public readonly string UserName;

	/// <summary>
	/// Password field
	/// </summary>
	public readonly string Password;

	/// <summary>
	/// constructor
	/// </summary>
	/// <param name="userName"></param>
	/// <param name="password"></param>
	public SwaggerCredentialsOptions(string userName, string password)
	{
		UserName = userName;
		Password = password;
	}
}
