using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Arguments.Task
{
    public class EditTaskResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public bool Success { get; set; }
        public string Message { get; set; }

        public EditTaskResponse(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }

        public EditTaskResponse(Guid id, string title, string description, int status, bool success, string message = "")
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            Success = success;
            Message = message;
        }
    }
}
