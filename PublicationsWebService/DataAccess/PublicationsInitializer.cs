using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using PublicationsWebService.Models;
using System.Reflection;
using System.IO;
using CsvHelper;

namespace PublicationsWebService.DataAccess
{
    class PublicationsInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PublicationsContext>
    {
        protected override void Seed(PublicationsContext context)
        {
            context.Database.Delete();
            
            using (StreamReader reader = new StreamReader(@".\DataAccess\SeedData\publication-list.csv"))
            {
                CsvReader csvReader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture);
                
                var records = csvReader.GetRecords<Publication>().ToList();
                records.ForEach(s=> context.Publications.AddOrUpdate(s));
                context.SaveChanges();

            }
            

            /*
            var publications = new List<Publication>
            {
                new Publication{ PublicationID=1, PublicationType="Books", Title="Test", Authors="Me", CreationDate=DateTime.Parse("2020-03-01")},
                new Publication{ PublicationID=2, PublicationType="Consultant Report", Title="222222", Authors="Me", CreationDate=DateTime.Parse("2019-01-01")}
            };

            publications.ForEach(s => context.Publications.Add(s));
            context.SaveChanges();
            */
        }
    }
}
