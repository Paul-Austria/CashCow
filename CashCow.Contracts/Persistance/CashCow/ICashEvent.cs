
using CommonBase.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Persistence.CashCow
{
    public interface ICashEvent : IVersionable, ICopyable<ICashEvent>
    {
        [ContractPropertyInfo(Required = true, MaxLength = 256, IsUnique = true)]
        string Title { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 1024)]
        string Description { get; set; }

        [ContractPropertyInfo(Required = true)]
        string Currency { get; set; }

        [ContractPropertyInfo(Required = false)]
        string ExtraInfo { get; set; }

        [ContractPropertyInfo(Required = true, MaxLength = 256)]
        string Category { get; set; }

        [ContractPropertyInfo(Required = true)]
        string Participants { get; set; }

    }
}