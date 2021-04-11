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
    public interface ITagRepository: IRepository<Tag>
    {

    }
    public class TagRepository: RepositoryBase<Tag>
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
