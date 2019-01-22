using Prova.Infra.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProvaContext _context;

        public UnitOfWork(ProvaContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
