using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
