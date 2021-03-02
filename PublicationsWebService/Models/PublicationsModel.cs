using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PublicationsWebService.Areas.HelpPage.ModelDescriptions;

namespace PublicationsWebService.Models
{
    [ModelName("Publication Model")]
    public class Publication
    {
        public int PublicationID { get; set; }
        public int PublicationTypeID { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime CreationDate { get; set; }
    }
}