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
    public interface IMenuRepository : IRepository<Menu>// 
    {

    }
    public class MenuRepository: RepositoryBase<Menu>,IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
