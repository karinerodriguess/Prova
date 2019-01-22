using Prova.Domain.Entities;
using Prova.Domain.Enums;
using Prova.Domain.Interfaces.Repositories;
using Prova.Infra.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prova.Infra.Persistence.Repositories
{
    public class RepositoryTask : IRepositoryTask
    {
        private readonly ProvaContext _context;

        public RepositoryTask(ProvaContext context)
        {
            _context = context;
        }

        public List<Task> GetAll()
        {
            return _context.Tasks.Where(x=>x.Status!= EnumStatusTask.Removed).ToList();
        }

        public Task GetById(Guid id)
        {
            return _context.Tasks.FirstOrDefault(x => x.Id == id);
        }

        public List<Task> GetByStatus(EnumStatusTask status)
        {
            return _context.Tasks.Where(x => x.Status == status).ToList();
        }

        public void Add(Task task)
        {
            _context.Tasks.Add(task);
        }

        public void Edit(Task task)
        {
            _context.Tasks.Update(task);
        }
    }
}
