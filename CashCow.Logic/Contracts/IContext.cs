//@BaseCode
using CashCow.Contracts;
using CashCow.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Contracts
{
    internal interface IContext : IDisposable
    {
        DbSet<E> Set<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C, new();
        Task<int> SaveChangeAsync();

        Task<int> CountAsync<C, E>()
            where C : IIdentifiable
            where E : IdentityEntity, C, new();


        Task<int> CountByAsync<C, E>(string predicate)
            where C : IIdentifiable
            where E : IdentityEntity, C, new();

        Task<C> GetByIdAsync<C,E>(int id)
              where C : IIdentifiable
            where E : IdentityEntity, C, new();

       Task<IEnumerable<E>> GetAllAsync<C,E>()
            where C : IIdentifiable
            where E : IdentityEntity, C, new();


       Task<IEnumerable<C>> QueryAll<C,E>() where C : IIdentifiable
            where E : IdentityEntity, C, new();




        public override Task<C> InsertAsync(C entity)
        {
            throw new System.NotImplementedException();
        }

        Task InsertAsync();
    }
}