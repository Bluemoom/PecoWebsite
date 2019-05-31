using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecoWeb.Data.Infrastructure
{
    class DbFactory : Disposable, IDbFactory
    {
        PecoWebDbContext dbContext;
        public PecoWebDbContext Init()
        {
            return dbContext ?? (dbContext = new PecoWebDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
