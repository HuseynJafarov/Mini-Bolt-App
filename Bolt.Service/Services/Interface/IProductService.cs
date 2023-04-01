using Bolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Service.Services.Interface
{
    public interface IProductService
    {
        public Task<string> CreateAsync(int restoranId,Product product);
        public Task<string> UpdateAsync(int id,Product product);
        public Task<string> RemoveAsync(int id);
        public Task<Product> GetAsync(int id);
        public Task<List<Product>> GetAllAsync();
    }
}
