//@BaseCode

using CashCow.Contracts;
using CashCow.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using CashCow.Logic.Contracts;

namespace CashCow.Logic.DataContext
{
    internal partial class CashCowDbContext : DbContext, Contracts.IContext
    {
        public Task<int> SaveChangeAsync()
        {
            return SaveChangesAsync();
        }


        public Task<int> CountAsync<C, E>()
           where C: IIdentifiable
            where E: IdentityEntity, C
        {
            throw new NotImplementedException();
        }


        public Task<int> CountByAsync<C,E> (string predicate) 
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            return Set<E>().Where(predicate).CountAsync();
        }
        public DbSet<E> Set<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C
        {
            throw new NotImplementedException();
        }

        public Task<E> GetByIdAsync<C, E>(int id)
            where C : IIdentifiable
            where E : IdentityEntity, C, new()
        {
            return  Set<C, E>().FindAsync(id);
        }

        Task<C> IContext.GetByIdAsync<C, E>(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<C>> GetAllAsync<C,E>() where C : IIdentifiable
        {
            return Set<C,E>().;
        }

        async Task<IEnumerable<E>> IContext.GetAllAsync<C, E>()
        {
            return await Set<C, E>().ToArrayAsync();
        }

        public Task<IEnumerable<C>> QueryAll<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C, new()
        {
            return await Set<C, E>().Where(predicate).toArrayAsync();
        }

        public Task InsertAsync()
        {
            throw new NotImplementedException();
        }
    }
}