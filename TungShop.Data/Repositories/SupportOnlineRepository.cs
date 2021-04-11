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
    public interface ISupportOnlineRepository: IRepository<SupportOnline>
    {

    }
    public class SupportOnlineRepository: RepositoryBase<SupportOnline>,ISupportOnlineRepository
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
