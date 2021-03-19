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
        private TungshopDbContext dbContext;
        public TungshopDbContext Init()
        {
            return dbContext ?? (dbContext = new TungshopDbContext());
        }   

        public override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
