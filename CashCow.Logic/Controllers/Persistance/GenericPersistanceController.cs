//@BaseCode

using CashCow.Logic.Contracts;
using CommonBase.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CashCow.Logic.Controllers.Persistance
{
    internal abstract partial class GenericPersistanceController<C, E> : GenericController<C, E>
        where C : CashCow.Contracts.IIdentifiable
        where E : Entities.IdentityEntity, C, new()
    {
        protected GenericPersistanceController(IContext context) : base(context)
        {
           
        }

        public override Task<int> CountAsync()
        {
            return Context.Set<C, E>().CountAsync();
        }

        public override Task<int> CountByAsync(string pre)
        {
            return Context.CountByAsync<C, E>(pre);
        }

        public override async Task<C> GetByIdAsync(int id)
        {
            return await Context.GetByIdAsync<C, E>(id).ConfigureAwait(false);
        }

        protected virtual E  BeforeReturn(E entity)
        {
            return entity;
        }

        public override async Task<C> GetByIdAsync(int id)
        {
            var result = await Context.GetByIdAsync<C, E>(id).ConfigureAwait(false);

            return BeforeReturn(result);
        }

        public override async Task<IEnumerable<C>> GetAllAsync()
        {
           return   await Context.GetAllAsync().ConfigureAwait(false).Select(e => BeforeReturn(e));

            
        }


        override async Task<IEnumerable<C>> QueryAll(string predicate)
        {
            var result = await Context.QueryAllAsync<C, E>(predicate)
                .ConfigureAwait(false).Select(e => BeforeReturn(e));
        }

        public override Task<C> CreateAsync()
        {
           throw new System.NotImplementedException();
        }

        protected virtual E BeforeInsert(E entity)
        {
            return entity;
        }
        public override async Task<C> InsertAsync(C entity)
        {
            entity.CheckArgument(nameof(entity));
            var insertEntity = new E();
            insertEntity.CopyProperties(entity);
            BeforeInsert(insertEntity);
            var result = await Context.InsertAsync().ConfigureAwait(false);
            AfterInsert(result);
            return result;
        }
        protected virtual E AfterInsert(E entity)
        {
            return entity;
        }

    }
}
