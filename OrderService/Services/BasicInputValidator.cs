
using OrderService.Interfaces;

namespace OrderService.Services
{
    internal class BasicInputValidator : IInputValidator
    {
        public bool Validate(string input, out string? validationError)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                validationError = "Введіть штрихкод";
                return false;
            }

            validationError = null;
            return true;
        }
    }
}
