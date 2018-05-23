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
using WebService.Model;

namespace WebService.Controllers
{
    public class MastersController : ApiController
    {
        private CircleKDBContext db = new CircleKDBContext();

        // GET: api/Masters
        public IQueryable<Master> GetMasters()
        {
            return db.Masters; //.Include(i => i.Employee).Include(i => i.Station);
        }

        // GET: api/Masters/5
        [ResponseType(typeof(Master))]
        public IHttpActionResult GetMaster(int id)
        {
            Master master = db.Masters.Find(id);
            if (master == null)
            {
                return NotFound();
            }

            return Ok(master);
        }

        // PUT: api/Masters/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMaster(int id, Master master)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != master.MasterID)
            {
                return BadRequest();
            }

            db.Entry(master).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MasterExists(id))
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

        // POST: api/Masters
        [ResponseType(typeof(Master))]
        public IHttpActionResult PostMaster(Master master)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Masters.Add(master);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = master.MasterID }, master);
        }

        // DELETE: api/Masters/5
        [ResponseType(typeof(Master))]
        public IHttpActionResult DeleteMaster(int id)
        {
            Master master = db.Masters.Find(id);
            if (master == null)
            {
                return NotFound();
            }

            db.Masters.Remove(master);
            db.SaveChanges();

            return Ok(master);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MasterExists(int id)
        {
            return db.Masters.Count(e => e.MasterID == id) > 0;
        }
    }
}