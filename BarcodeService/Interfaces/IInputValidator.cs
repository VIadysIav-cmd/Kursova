

namespace BarcodeService.Interfaces
{
    public interface IInputValidator
    {
        bool Validate(string input, out string? errorMessage);
    }
}
