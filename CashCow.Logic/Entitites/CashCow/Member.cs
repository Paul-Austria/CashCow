using CashCow.Contracts.Persistance.CashCow;
using CashCow.Contracts.Persistence.CashCow;
using CashCow.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entitites.CashCow
{
    class Member : VersionEntity, IMember
    {
        public string Name { get; set; }

        public void CopyProperties(IPayment other)
        {
        }
    }
}
