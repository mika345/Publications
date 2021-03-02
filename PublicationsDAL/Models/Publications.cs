using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublicationsDAL.DAL;

namespace PublicationsDAL.Models
{
    public class Publications
    {

        #region Data Models

        public partial class get_Publications
        {
            public int publicationID { get; set; }
            public int publicationTypeID { get; set; }
            public string title { get; set; }
            public int authorsID { get; set; }
            public DateTime creationDate { get; set; }
        }

        #endregion

        /// <summary>
        /// Gets list of publications
        /// </summary>
        /// <returns>List of publications</returns>
        public static IEnumerable<get_Publications> getPublications()
        {
            //returns all publications

            return new PublicationsContext().Publications;

        }

    }
}
