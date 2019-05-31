﻿using PecoWeb.Data.Infrastructure;
using PecoWeb.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PecoWeb.Data.Repositories
{
    public interface IFooterRepository
    {

    }
    public class FooterRepository : RepositoryBase<Footer>, IProductRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
