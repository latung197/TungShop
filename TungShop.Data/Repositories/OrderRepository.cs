using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Data.Infrastructure;
using TungShop.Model.Infrastructure;
using TungShop.Model.Model;
namespace TungShop.Data.Repositories
{
    public interface IOrderRepository:IRepository<Order>
    {

    }
    public class OrderRepository:RepositoryBase<Order>,IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory ): base(dbFactory)
        {

        }

    }
}
