using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Core.Repositeries
{
    public interface IRepository<T>
    {
        public Task AddAsync(T model);
        public Task RemoveAsync(T model);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetAsync(Func<T, bool> expression);
        public Task UpdateAsync(T model);
    }
}
