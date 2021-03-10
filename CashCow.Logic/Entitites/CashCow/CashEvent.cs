using CashCow.Contracts.Persistance.CashCow;
using CashCow.Contracts.Persistence.CashCow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Entities.CashCow
{
    class CashEvent : VersionEntity, ICashEvent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Currency { get; set; }
        public string ExtraInfo { get; set; }
        public string Category { get; set; }
        public string Participants { get; set; }
        List<IMember> ICashEvent.Participants { get; set; }

        public void CopyProperties(ICashEvent other)
        {
        }
    }
}