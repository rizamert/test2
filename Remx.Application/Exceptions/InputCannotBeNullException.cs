using Remx.Application.Base.Exceptions;
using Remx.Application.Exceptions.Enums;

namespace Remx.Application.Exceptions;

public class InputCannotBeNullException : BaseException
{
    public InputCannotBeNullException(string title, string message) : base(title, message)
    {
    }

    public InputCannotBeNullException(string title, string message, ExceptionTypesEnum? exceptionType) : base(title, message, exceptionType)
    {
    }

    public InputCannotBeNullException(string title, string message, ExceptionTypesEnum? exceptionType, Exception innerException) : base(title, message, exceptionType, innerException)
    {
    }
}