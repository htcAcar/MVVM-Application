using System;
using System.Globalization;
using System.Windows.Controls;

namespace StartApp.ValidationRules
{
    public class RequiredValidationRule : ValidationRule
    {
        public static string _errorMessage = string.Empty;
        public static string GetErrorMessage(string fieldName, object fieldValue, object nullValue = null)
        {
            if (fieldValue == null || string.IsNullOrEmpty(fieldValue.ToString()))
            {
              _errorMessage = string.Format("You can't leave this field empty.");
            }
            return _errorMessage;
        }
        public string FieldName { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string error = GetErrorMessage(FieldName, value);
            if (!string.IsNullOrEmpty(error))
            {
                return new ValidationResult(false, error);
            }
            return ValidationResult.ValidResult;
        }

    }
}

