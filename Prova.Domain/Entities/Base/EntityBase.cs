using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Entities.Base
{
    public abstract class EntityBase: Notifiable
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
