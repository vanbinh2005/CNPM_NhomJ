using KoiOderingSystemsRepositories.Entities;
using KoiOderingSystemsRepositories.Interfaces;
using KoiOderingSystemsServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiOderingSystemsServices.Services
{
    public class OrderServicem : IOrderServices
    {
        private readonly IOrdersRepository _repository;
        public OrderServicem(IOrdersRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Order>> Getorders()
        {
            return _repository.GetAllOrders();
        }
    }
}
