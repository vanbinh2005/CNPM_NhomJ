using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;

namespace KoiOderingSystemsServices.Services
{
    internal class ProductServices : IProductServices
    {
        private readonly IProductRepository _repository;
        public ProductServices(IProductRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Product>> products()
        {
            return _repository.GetAllProducts();
        }
    }
}
