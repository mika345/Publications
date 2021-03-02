using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using PublicationsDAL.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PublicationsDAL.DAL
{
    class PublicationsContext
           : DbContext
    {

        public PublicationsContext() : base ("PublicationsContext")
        {
        }

        public DbSet<Publications.get_Publications> Publications
        { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
