using Bolt.Core.Enum;
using Bolt.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bolt.Service.Services.Interface
{
    public interface IRestoranService
    {
        public Task<string> CreateAsync(RestorantCategory restoranCategory);
        public Task<string> UpdateAsync(int id, RestorantCategory restorantCategory);
        public Task<string> RemoveAsync(int id);
        public Task<Restorant> GetAsync(int id);
        public Task<List<Restorant>> GetAllAsync();
        public Task<List<Product>> GetProductByRestoran(string name);
    }
}
