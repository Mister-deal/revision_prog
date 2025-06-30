namespace Calculatrice;

public class NonNumericalValueException : Exception
{
    public NonNumericalValueException(string? message) : base(message)
    {
    }
}