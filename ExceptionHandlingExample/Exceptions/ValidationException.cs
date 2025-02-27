namespace ExceptionHandlingExample.Exceptions;

public class ValidationException:Exception
{
    public ValidationException(string mesaj):base(mesaj)
    {
        
    }
}
