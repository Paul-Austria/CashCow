using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Contracts.Client
{
    public partial interface IControllerAccess<T> :IDisposable where T: IIdentifiable
    {
        Task<int> CountAsync();
        Task<int> CountByAsync(string predicate);
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> QueryAllAsync(string predicate);
        Task<T> CreateAsync();
        Task<T> InsertAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(int entity);
        Task SaveChangesAsync();
    }
}
