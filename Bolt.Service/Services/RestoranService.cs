using Bolt.Core.Enum;
using Bolt.Core.Models;
using Bolt.Core.Repositeries.RestorantRepositery;
using Bolt.Data.Repositories.ProductRespository;
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
        private int _id;

        private readonly IRestoranRepository _repository;

        public RestoranService(IRestoranRepository repository)
        {
            _repository = repository;
        }


        public async Task<string> CreateAsync(RestorantCategory restoranCategory)
        {
            Restorant restorant = new Restorant(restoranCategory);
            restorant.Id = _id;
            _id++;
            Console.ForegroundColor = ConsoleColor.Green;
            await _repository.AddAsync(restorant);
            return "Succesfully Created";
        }

        public async Task<List<Restorant>> GetAllAsync()
        { 
            return  await _repository.GetAllAsync();
        }

        public async Task<Restorant> GetAsync(int id)
        {

            Restorant restorant = await _repository.GetAsync(m => m.Id == id);
            if (restorant is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Restorant Not Found");
            }
            return restorant;
        }

        public async Task<List<Product>> GetProductByRestoran(string name)
        {
            Restorant restorant = await _repository.GetAsync(a => a.Name == name);
            if (restorant == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Restoran is not found");
                return null;
            }
            return restorant.ProductList;
        }

        public async Task<string> RemoveAsync(int id)
        {
            Restorant restorant = await _repository.GetAsync(a => a.Id == id);
            if (restorant is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Restoran is not found";
            }

            await _repository.RemoveAsync(restorant);

            Console.ForegroundColor = ConsoleColor.Green;
            return "Succesfuly removed";
        }

        public async Task<string> UpdateAsync(int id, RestorantCategory restorantCategory)
        {
            Restorant restorant = await _repository.GetAsync(a => a.Id == id);
            if (restorant is null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Restoran is not found";
            }

            await _repository.UpdateAsync(restorant);
            Console.ForegroundColor = ConsoleColor.Green;
            return "Succesfuly updated";

        }
    }
}
