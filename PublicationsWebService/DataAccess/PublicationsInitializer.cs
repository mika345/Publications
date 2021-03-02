using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using PublicationsWebService.Models;

namespace PublicationsWebService.DataAccess
{
    class PublicationsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PublicationsContext>
    {
        protected override void Seed(PublicationsContext context)
        {
            //base.Seed(context);

            var publications = new List<Publication>
            {
                new Publication{ PublicationID=1, PublicationTypeID=1, Title="Test", Authors="Me", CreationDate=DateTime.Parse("2020-03-01")},
                new Publication{ PublicationID=2, PublicationTypeID=1, Title="222222", Authors="Me", CreationDate=DateTime.Parse("2019-01-01")}
            };

            publications.ForEach(s=> context.Publications.Add(s));
            context.SaveChanges();
        }
    }
}
