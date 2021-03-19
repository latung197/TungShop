using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TungShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {

        private bool IsDisposed;
        // ~ tuong tu using tự động hủy
        ~Disposable()
        {
            Dispose(false);
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!IsDisposed && disposing)
            {
                DisposeCore();
            }
            IsDisposed = true;
        }
        //  Lớp dọn rác hệ thống
        public virtual void DisposeCore()
        {

        }
    }
}
