﻿using System.ComponentModel.DataAnnotations;

namespace OtbasyBank.Shared.Extensions.Options;

public static class DataAnnotationsValidator
{
	public static bool TryValidate(object instance, out ICollection<ValidationResult> results)
	{
		var context = new ValidationContext(instance);
		results = new List<ValidationResult>();

		return Validator.TryValidateObject(instance, context, results, true);
	}
}
