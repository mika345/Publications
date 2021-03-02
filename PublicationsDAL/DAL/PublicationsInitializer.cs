using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using PublicationsDAL.Models;

namespace PublicationsDAL.DAL
{
    class PublicationsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PublicationsContext>
    {
        protected override void Seed(PublicationsContext context)
        {
            //base.Seed(context);

            var publications = new List<Publications.get_Publications>
            {
                new Publications.get_Publications{ publicationID=1, publicationTypeID=1, title="Test", authorsID=1, creationDate=DateTime.Parse("2020-03-01")}
            };

            publications.ForEach(s=> context.Publications.Add(s));
            context.SaveChanges();
        }
    }
}
