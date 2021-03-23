using CashCow.Contracts.Persistence.CashCow;
using CashCow.Logic.Contracts;
using CashCow.Logic.Entities.CashCow;
using CashCow.Logic.Controllers.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Controllers.Persistance
{
    class CashEventController : GenericPersistenceController<ICashEvent, CashEvent>
    {
        public CashEventController(IContext context) : base(context)
        {
        }

        public CashEventController(ControllerObject other) : base(other)
        {
        }
    }
}
