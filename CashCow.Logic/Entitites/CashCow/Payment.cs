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
        public string Payer { get; set; }

        public void CopyProperties(IPayment other)
        {
            other.CheckArgument(nameof(other));

            Id = other.Id;
            RowVersion = other.RowVersion;
            Title = other.Title;
            Amount = other.Amount;
            Date = other.Date;
            Payer = other.Payer;
        }
    }
}