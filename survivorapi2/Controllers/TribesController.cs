using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using survivorapi2.Models;

namespace survivorapi2.Controllers
{
    public class TribesController : ApiController
    {
        private survivorapi2Context db = new survivorapi2Context();

        // GET: api/Tribes
        public IQueryable<Tribe> GetTribes()
        {
            return db.Tribes;
        }

        // GET: api/Tribes/5
        [ResponseType(typeof(Tribe))]
        public async Task<IHttpActionResult> GetTribe(int id)
        {
            Tribe tribe = await db.Tribes.FindAsync(id);
            if (tribe == null)
            {
                return NotFound();
            }

            return Ok(tribe);
        }

        // PUT: api/Tribes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTribe(int id, Tribe tribe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tribe.Id)
            {
                return BadRequest();
            }

            db.Entry(tribe).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TribeExists(id))
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

        // POST: api/Tribes
        [ResponseType(typeof(Tribe))]
        public async Task<IHttpActionResult> PostTribe(Tribe tribe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Tribes.Add(tribe);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = tribe.Id }, tribe);
        }

        // DELETE: api/Tribes/5
        [ResponseType(typeof(Tribe))]
        public async Task<IHttpActionResult> DeleteTribe(int id)
        {
            Tribe tribe = await db.Tribes.FindAsync(id);
            if (tribe == null)
            {
                return NotFound();
            }

            db.Tribes.Remove(tribe);
            await db.SaveChangesAsync();

            return Ok(tribe);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TribeExists(int id)
        {
            return db.Tribes.Count(e => e.Id == id) > 0;
        }
    }
}