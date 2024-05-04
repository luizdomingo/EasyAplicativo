using System.ComponentModel.DataAnnotations;

namespace Easy.Application.Shared
{
    public static class ValidarDataAnnotation
    {
        public static string VerificarDataAnnotations(object objeto)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(objeto, serviceProvider: null, items: null);
            Validator.TryValidateObject(objeto, context, results, validateAllProperties: true);

            return string.Join(Environment.NewLine, results.Select(r => r.ErrorMessage));
        }
    }
}
