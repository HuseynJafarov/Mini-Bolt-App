using Bolt.Core.Models;
using Bolt.Data.Repositories.ProductRespository;
using Bolt.Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolt.Service.Services
{
    public class ProductService : IProductService
    {
        private int _id;
        private readonly RestoranRepository _repository;

        public ProductService(RestoranRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> CreateAsync(int restoranId, Product product)
        {
            Restorant restorant = await _repository.GetAsync(m=> m.Id == product.Restorant.Id);

            if (restorant == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "Restoran is not valid";
            }

            Product dataProduct = new Product()
            {
                CreateDate = DateTime.Now,
                ProductName = product.ProductName,
                Price = product.Price,
                Restorant = product.Restorant,
                ProductEnum = product.ProductEnum,
            };

            restorant.ProductList.Add(dataProduct);
            product.Id = _id;
            _id++;

            Console.ForegroundColor = ConsoleColor.Green;
            return "Succesfuly created";
        }

        public async Task<List<Product>> GetAllAsync()
        {
            List<Restorant> restorants = await _repository.GetAllAsync();

            List<Product> products = new List<Product>();

            foreach (Restorant item in restorants)
            {
                products.AddRange(item.ProductList);
            }
            return products;
        }

        public async Task<Product> GetAsync(int id)
        {
            List<Restorant> restorants = await _repository.GetAllAsync();

            foreach (Restorant item in restorants)
            {
                Product product = item.ProductList.Find(m => m.Id == id);
                if(product != null)
                {
                    return product;
                }
            }
            return null;
        }

        public async Task<string> RemoveAsync(int id)
        {
            List<Restorant> restorants = await _repository.GetAllAsync();

            foreach (Restorant item in restorants)
            {
                Product product = item.ProductList.Find(m => m.Id == id);
                if (product != null)
                {
                   item.ProductList.Remove(product);
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "Succesfuly removed";
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;

            return "Student is not found";
        }

        public async Task<string> UpdateAsync(int id, Product product)
        {
            List<Restorant> restorants = await _repository.GetAllAsync();

            foreach (var item in restorants)
            {
                Product dbProduct = item.ProductList.Find(m => m.Id == id);
                if (dbProduct != null)
                {
                    dbProduct.ProductName = product.ProductName;
                    dbProduct.Price = product.Price;
                    dbProduct.ProductEnum = product.ProductEnum;
                    dbProduct.UpdateDate = DateTime.Now;
                    dbProduct.Restorant = product.Restorant;
                    Console.ForegroundColor = ConsoleColor.Green;
                    return "Succesfuly Updated";
                }
            }
                Console.ForegroundColor = ConsoleColor.Red;
                return "Student is not found";
        }
    }
}
