using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Arguments.Task
{
    public class RemoveTaskResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public RemoveTaskResponse(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }
    }
}
