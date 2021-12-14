using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArch.Infra.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext productContext;
        public ProductRepository(ApplicationDbContext context)
        {
            productContext = context;
        }
        public Task<Product> Create(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetById(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProduct(int? id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Remove(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> Update(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
