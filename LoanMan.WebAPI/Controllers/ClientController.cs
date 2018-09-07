using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using LoanMan.WebAPI.Models;

namespace LoanMan.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientController : ApiController
    {
        private LoanManModelContainer db = new LoanManModelContainer();

        // GET: api/Client
        public IQueryable<tbl_Client> Gettbl_Client()
        {
            return db.tbl_Client;
        }

        // GET: api/Client/5
        [ResponseType(typeof(tbl_Client))]
        public IHttpActionResult Gettbl_Client(int id)
        {
            tbl_Client tbl_Client = db.tbl_Client.Find(id);
            if (tbl_Client == null)
            {
                return NotFound();
            }

            return Ok(tbl_Client);
        }

        // PUT: api/Client/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puttbl_Client(int id, tbl_Client tbl_Client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tbl_Client.ClientId)
            {
                return BadRequest();
            }

            db.Entry(tbl_Client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tbl_ClientExists(id))
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

        // POST: api/Client
        [ResponseType(typeof(void))]
        public IHttpActionResult Posttbl_Client(tbl_Client Client)
        {
            tbl_Client c = new tbl_Client();
            c.DateAdded = DateTime.Now;
            c.DOB = Client.DOB;
            


            tbl_Client_Address ca = new tbl_Client_Address();

            if (Client.tbl_Client_Address != null)
            {
                //ca.StreetAddress1 = Client.tbl_Client_Address.StreetAddress;
            }
            //
            //string a = Client.tbl_Client_Address.StreetAddress1;
            db.tbl_Client_Address.Add(ca);

            db.tbl_Client.Add(c);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Client.ClientId }, Client);
        }

        // DELETE: api/Client/5
        [ResponseType(typeof(tbl_Client))]
        public IHttpActionResult Deletetbl_Client(int id)
        {
            tbl_Client tbl_Client = db.tbl_Client.Find(id);
            if (tbl_Client == null)
            {
                return NotFound();
            }

            db.tbl_Client.Remove(tbl_Client);
            db.SaveChanges();

            return Ok(tbl_Client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tbl_ClientExists(int id)
        {
            return db.tbl_Client.Count(e => e.ClientId == id) > 0;
        }
    }
}