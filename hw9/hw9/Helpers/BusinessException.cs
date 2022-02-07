using System;

namespace Hw9
{
    public class BusinessException : Exception
    {
        public BusinessException(string exMessage)
            : base(exMessage)
        {
            ExceptionText = exMessage;
        }

        public string ExceptionText { get; set; }
    }
}
