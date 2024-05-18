namespace CajeroAutomatico;

public class InvalidLengthNumberException : Exception
{
    public InvalidLengthNumberException() : base("El número ingresado es invalido.") { }

    public InvalidLengthNumberException(string message) : base(message) { }
}