using CommonBase.Extensions;
using CashCow.Contracts;
using CashCow.Contracts.Client;
using CashCow.Logic.Contracts;
using CashCow.Logic.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic
{
	partial class Factory
	{
		static partial void CreateController<C>(IContext context, ref IControllerAccess<C> controller) where C : IIdentifiable
		{
			if (typeof(C) == typeof(CashCow.Contracts.Persistence.CashCow.ICashEvent))
			{
				controller = new Controllers.Persistance.CashEventController(context) as IControllerAccess<C>;
			}
		}
		static partial void CreateController<C>(ControllerObject controllerObject, ref IControllerAccess<C> controller) where C : IIdentifiable
		{
			controllerObject.CheckArgument(nameof(controllerObject));

			if (typeof(C) == typeof(CashCow.Contracts.Persistence.CashCow.ICashEvent))
			{
				controller = new Controllers.Persistance.CashEventController(controllerObject) as IControllerAccess<C>;
			}
		}
	}
}
