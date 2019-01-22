using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Arguments.Task
{
    public class EditTaskRequest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
