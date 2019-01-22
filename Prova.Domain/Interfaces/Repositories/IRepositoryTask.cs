using Prova.Domain.Entities;
using Prova.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Domain.Interfaces.Repositories
{
    public interface IRepositoryTask
    {
        Task GetById(Guid id);
        List<Task> GetAll();
        void Add(Task task);
        void Edit(Task task);
        List<Task> GetByStatus(EnumStatusTask status);
    }
}
