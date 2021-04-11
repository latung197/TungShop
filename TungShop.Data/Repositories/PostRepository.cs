using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Data.Infrastructure;
using TungShop.Model.Model;
using TungShop.Model.Infrastructure;
using System.Linq;

namespace TungShop.Data.Repositories
{
    public interface IPostRepository: IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(String tag, int pageIndex, int pageSize, out int totolRow);
    }
    public class PostRepository:RepositoryBase<Post>,IPostRepository
    {
        public PostRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totolRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag
                        select p;

            totolRow = query.Count();
            query = query.Skip((pageIndex-1)* pageSize).Take(pageSize);
            return query;
        }
    }
}
