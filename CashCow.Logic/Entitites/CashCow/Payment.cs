using CashCow.Contracts.Persistance.CashCow;
using CashCow.Contracts.Persistence.CashCow;
using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashCow.Logic.Entities.CashCow
{
    class Payment : VersionEntity, IPayment
    {
        public string Title { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        IMember IPayment.Payer { get; se; }

        public void CopyProperties(IPayment other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            Title = other.Title;
            Amount = other.Amount;
            Date = other.Date;
        }
    }
}