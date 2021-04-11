using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Model.Model;
using TungShop.Data.Infrastructure;
using TungShop.Data.Repositories;
using TungShop.Model.Infrastructure;

namespace TungShop.Data.Repositories
{
    public interface IFooterRepository: IRepository<Footer>// Interface chiển khai các phương thức khác
    {
        IEnumerable<Footer> GetByContent(string content);
    }
    public class FooterRepository : RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Footer> GetByContent(string content)
        {
            return this.DbContext.Footers.Where(x => x.Content == content);
        }
    }
}
