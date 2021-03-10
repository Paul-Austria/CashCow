using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistance.CashCow
{
    public interface IMember : IVersionable, ICopyable<IPayment>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string Name { get; set; }
    }
}
