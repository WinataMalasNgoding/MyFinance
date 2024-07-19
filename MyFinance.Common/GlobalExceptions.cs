using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinance.Common
{
    public class GlobalExceptions : Exception
    {
        public string? message {  get; set; }
        public Exception exception {  get; set; }
        public object data {  get; set; }

        public GlobalExceptions()
        {

        }

        public GlobalExceptions(object data)
        {
            this.data = data;
        }

        public GlobalExceptions(string message)
        {
            this.message = message;
        }

        public GlobalExceptions(string message, Exception innerException) : base(message, innerException)
        {
            this.message = message;
            this.exception = innerException;
        }

        public string StatusCode(int statusCode) 
        {
            string messageStatusCode = string.Empty;

            switch (statusCode)
            {
                case 200:
                    messageStatusCode = "OK";
                    break;
                case 400:
                    messageStatusCode = "BAD_REQUEST";
                    break;
                case 404:
                    messageStatusCode = "NOT_FOUND";
                    break;
                case 411:
                    messageStatusCode = "LENGTH_REQUIRED";
                    break;
                default:
                    break;
            }
            return messageStatusCode;
        }

        public object StatusData(Exception ex)
        {
            if (ex.InnerException == null)
            {
                return ex.Message;
            }
            else if (ex.InnerException.InnerException.InnerException == null)
            {
                return ex.InnerException.InnerException.Message;
            }
            else
            {
                return ex.InnerException.InnerException.InnerException.Message;
            }
        }
    }
}
