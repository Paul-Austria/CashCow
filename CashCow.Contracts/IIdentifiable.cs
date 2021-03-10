
//@BaseCode
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts
{
    public partial interface IIdentifiable
    {
        int Id { get; }
    }
}