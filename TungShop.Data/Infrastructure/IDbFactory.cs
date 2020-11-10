using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Data;

namespace TungShop.Model.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TungshopDbContext Init();

    }
}
