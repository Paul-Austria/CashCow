using CashCow.Contracts.Client;
using CashCow.Logic.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Controllers
{
    internal abstract class GenericController<C, E> :ControllerObject, CashCow.Contracts.Client.IControllerAccess<C>
        where C : CashCow.Contracts.IIdentifiable
        where E : Entities.IdentityEntity,C, new()
    {

        protected GenericController(IContext context) : base(context)
        {
        }

        protected GenericController(ControllerObject other) : base(other)
        {
        }

        public abstract Task<int> CountAsync();


        public abstract Task<int> CountByAsync(string predicate);

        public virtual Task<C> CreateAsync()
        {
            return Task.Factory.StartNew<C>(() => new E());
        }

        public abstract Task DeleteAsync(int entity);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public abstract Task<IEnumerable<C>> GetAllAsync();
        public abstract Task<C> GetByIdAsync(int id);

        public abstract Task<C> InsertAsync(C entity);

        public  abstract Task<IEnumerable<C>> QueryAllAsync(string predicate);

        public virtual Task<int> SaveChangesAsync()
        {
            return Context.SaveChangeAsync();
        }
        public  abstract Task<C> UpdateAsync(C entity);

        Task IControllerAccess<C>.SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
