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
using API_PHONE.Models;

namespace API_PHONE.Controllers
{
    public class api_phoneController : ApiController
    {
        private DataContext db = new DataContext();

        // GET: api/api_phone
        public IQueryable<api_phone> Getapi_phone()
        {
            return db.api_phone;
        }

        // GET: api/api_phone/5
        [ResponseType(typeof(api_phone))]
        public IHttpActionResult Getapi_phone(int id)
        {
            api_phone api_phone = db.api_phone.Find(id);
            if (api_phone == null)
            {
                return NotFound();
            }

            return Ok(api_phone);
        }

        // PUT: api/api_phone/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapi_phone(int id, api_phone api_phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != api_phone.PersonID)
            {
                return BadRequest();
            }

            db.Entry(api_phone).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!api_phoneExists(id))
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

        // POST: api/api_phone
        [ResponseType(typeof(api_phone))]
        public IHttpActionResult Postapi_phone(api_phone api_phone)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.api_phone.Add(api_phone);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = api_phone.PersonID }, api_phone);
        }

        // DELETE: api/api_phone/5
        [ResponseType(typeof(api_phone))]
        public IHttpActionResult Deleteapi_phone(int id)
        {
            api_phone api_phone = db.api_phone.Find(id);
            if (api_phone == null)
            {
                return NotFound();
            }

            db.api_phone.Remove(api_phone);
            db.SaveChanges();

            return Ok(api_phone);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool api_phoneExists(int id)
        {
            return db.api_phone.Count(e => e.PersonID == id) > 0;
        }
    }
}