using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Model.Model;
using TungShop.Model.Infrastructure;
using TungShop.Data.Infrastructure;
namespace TungShop.Data.Repositories
{
    public interface IPostCategoryRepository:IRepository<PostCategory>
    {

    }
    public class PostCategoryRepository: RepositoryBase<PostCategory>,IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
    
}
