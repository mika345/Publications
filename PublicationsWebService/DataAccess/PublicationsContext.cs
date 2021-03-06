﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PublicationsWebService.Models;

namespace PublicationsWebService.DataAccess
{
    public class PublicationsContext
           : DbContext
    {

        public PublicationsContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Publication> Publications
        { get; set; }

    }
}