using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Model.Infrastructure;

namespace TungShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IDbFactory dbFactory;
        private TungshopDbContext dbContext;
        public UnitOfWork (IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public TungshopDbContext DbContext()
        {
           return dbContext ?? (dbContext = dbFactory.Init()); 
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
