using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Model.Infrastructure;

namespace TungShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        public TungshopDbContext Init()
        {
            throw new NotImplementedException();
        }
    }
}
