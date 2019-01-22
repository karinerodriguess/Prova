using prmToolkit.NotificationPattern;
using Prova.Domain.Entities.Base;
using Prova.Domain.Enums;
using System;

namespace Prova.Domain.Entities
{
    public class Task : EntityBase
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public EnumStatusTask Status { get; set; }
        public DateTime CreatedDate { get; private set; }
        public DateTime ModifiedDate { get; private set; }
        public DateTime RemovedDate { get; set; }

        protected Task() { }

        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;

            new AddNotifications<Task>(this).IfNullOrInvalidLength(x => x.Title, 5, 30, "O campo Título deve conter entre 5 e 30 caracteres.");
            new AddNotifications<Task>(this).IfNullOrInvalidLength(x => x.Description, 10, 300, "O campo Descrição deve conter entre 10 e 300 caracteres.");
        }

        public Task(Guid id, string title, string description, DateTime createdDate, EnumStatusTask status)
        {
            Id = id;
            Title = title;
            Description = description;
            Status = status;
            ModifiedDate = DateTime.Now;
            CreatedDate = createdDate;

            if (status == EnumStatusTask.Removed)
            {
                RemovedDate = DateTime.Now;
            }

            new AddNotifications<Task>(this).IfNullOrInvalidLength(x => x.Title, 5, 30);
            new AddNotifications<Task>(this).IfNullOrInvalidLength(x => x.Description, 10, 300);
        }

    }
}
