using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace OtbasyBank.Api.Controllers;

/// <summary>
/// base controller to resolve Mediator and Mapper
/// </summary>
[ApiController]
public class BaseController : ControllerBase
{
	/// <summary>
	///     Gets the mediator.
	/// </summary>
	/// <value>The mediator.</value>
	protected ISender Mediator =>
		HttpContext.RequestServices.GetService<ISender>() ??
		throw new ArgumentNullException(nameof(ISender));

	/// <summary>
	///     Gets the mapper.
	/// </summary>
	/// <value>The mediator.</value>
	protected IMapper Mapper =>
		HttpContext.RequestServices.GetService<IMapper>() ??
		throw new ArgumentNullException(nameof(IMapper));
}
