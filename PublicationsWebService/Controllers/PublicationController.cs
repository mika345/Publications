using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PublicationsWebService.DataAccess;
using PublicationsWebService.Models;

namespace PublicationsWebService.Controllers
{
    public class PublicationController : ApiController
    {
        //create a new isntance of the publications context and pass in the database connection string
        private PublicationsContext db = new PublicationsContext("DefaultConnection");

        /// <summary>
        /// Gets the list of publications
        /// </summary>
        /// <returns>A queryable collection of publications</returns>
        // GET: api/Publication
        public IQueryable<Publication> GetPublications()
        {
            return db.Publications;
        }
        
         // GET: api/Publication/5
        [ResponseType(typeof(Publication))]
        public IHttpActionResult GetPublication(int id)
        {
            Publication publication = db.Publications.Find(id);
            if (publication == null)
            {
                return NotFound();
            }

            return Ok(publication);
        }

                // PUT: api/Publication/5
                [ResponseType(typeof(void))]
                public IHttpActionResult PutPublication(int id, Publication publication)
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    if (id != publication.PublicationID)
                    {
                        return BadRequest();
                    }

                    db.Entry(publication).State = EntityState.Modified;

                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!PublicationExists(id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                    return StatusCode(HttpStatusCode.NoContent);
                }

                // POST: api/Publication
                [ResponseType(typeof(Publication))]
                public IHttpActionResult PostPublication(Publication publication)
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(ModelState);
                    }

                    db.Publications.Add(publication);
                    db.SaveChanges();

                    return CreatedAtRoute("DefaultApi", new { id = publication.PublicationID }, publication);
                }

                // DELETE: api/Publication/5
                [ResponseType(typeof(Publication))]
                public IHttpActionResult DeletePublication(int id)
                {
                    Publication publication = db.Publications.Find(id);
                    if (publication == null)
                    {
                        return NotFound();
                    }

                    db.Publications.Remove(publication);
                    db.SaveChanges();

                    return Ok(publication);
                }

                protected override void Dispose(bool disposing)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                    base.Dispose(disposing);
                }

                private bool PublicationExists(int id)
                {
                    return db.Publications.Count(e => e.PublicationID == id) > 0;
                }
        
    }
}