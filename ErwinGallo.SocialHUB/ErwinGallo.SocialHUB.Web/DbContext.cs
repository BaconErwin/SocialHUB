using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErwinGallo.SocialHUB.Web.Infrastructure.Data.Helpers;
using Microsoft.EntityFrameworkCore;

namespace ErwinGallo.SocialHUB.Web
{
    public class DbContext
    {
        private DbContextOptions<DefaultDbContext.DefaultDbContext> options;

        public DbContext(DbContextOptions<DefaultDbContext.DefaultDbContext> options)
        {
            this.options = options;
        }

        internal void OnModelCreating(ModelBuilder modelBuilder)
        {
            throw new NotImplementedException();
        }
    }
}
