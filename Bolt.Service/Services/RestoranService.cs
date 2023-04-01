using Bolt.Core.Enum;
using Bolt.Core.Models;
using Bolt.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Service.Services
{
    public class RestoranService : IRestoranService
    {
        public Task<string> CreateAsync(RestorantCategory restoranCategory)
        {
            throw new NotImplementedException();
        }

        public Task<List<Restorant>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Restorant> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductByRestoran(string name)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(int id, RestorantCategory restorantCategory)
        {
            throw new NotImplementedException();
        }
    }
}
