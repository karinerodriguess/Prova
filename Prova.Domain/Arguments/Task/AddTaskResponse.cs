using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Arguments.Task
{
    public class AddTaskResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public AddTaskResponse(Guid id, string message = "")
        {
            Id = id;
            Message = message;
        }
    }
}
