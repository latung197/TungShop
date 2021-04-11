using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Data.Infrastructure;
using TungShop.Model.Model;
using TungShop.Model.Infrastructure;

namespace TungShop.Data.Repositories
{
    public interface IPostTagRepository: IRepository<PostTag>
    {

    }

    public class PostTagRepository:RepositoryBase<PostTag>,IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
