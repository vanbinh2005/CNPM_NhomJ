
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiOderingSystemsRepositories.Entities;

namespace KoiOderingSystemsServices.Interfaces
{
    internal interface IProductServices
    {
        Task<List<Product>> products();
    }
}
