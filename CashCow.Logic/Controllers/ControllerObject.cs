//@BaseCode
using CommonBase.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Controllers
{
    internal abstract partial class ControllerObject : IDisposable
    {
        private bool contextOwner;
        protected Contracts.IContext Context { get; set; }
        public ControllerObject(Contracts.IContext context)
        {
            context.CheckArgument(nameof(context));
            Context = context;
            contextOwner = true;
        }
        public ControllerObject(ControllerObject other)
        {
            other.CheckArgument(nameof(other));

            contextOwner = false;
            Context = other.Context;
        }

        #region Dispose pattern
        private bool disposedValue;


        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (contextOwner)
                    {
                        Context.Dispose();
                    }
                    Context = null;
                }
                disposedValue = true;
            }
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion Dispose pattern
    }
}