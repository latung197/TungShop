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
    public interface ISlideRepository: IRepository<Slide>
    {

    }

    public class SlideRepository:RepositoryBase<Slide>
    {
        public SlideRepository(IDbFactory dbFactory): base(dbFactory)
        {

        }
    }
}
