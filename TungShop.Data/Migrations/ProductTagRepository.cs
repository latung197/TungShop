using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Data.Infrastructure;
using TungShop.Model.Model;
using TungShop.Model.Infrastructure;

namespace TungShop.Data.Migrations
{
    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository: RepositoryBase<ProductTag>
    {
        public ProductTagRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
