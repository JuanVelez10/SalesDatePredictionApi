using Application.Contracts.Persistence;
using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IProductRepository productRepository;

        public ProductServices (IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Get(int id)
        {
            return productRepository.Get(id);
        }

        public async Task<List<Product>> GetAll()
        {
            return productRepository.GetAll();
        }


    }
}
