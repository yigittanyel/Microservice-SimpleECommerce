namespace OrderService.Exceptions;

public class NullException : Exception
{
    public NullException()
    {
    }

    public NullException(string entityName)
        : base($"{entityName} is null.")
    {
    }
}
