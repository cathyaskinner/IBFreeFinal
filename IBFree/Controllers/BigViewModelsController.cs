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
using IBFree.Models;

namespace IBFree.Controllers
{
    public class BigViewModelsController : ApiController
    {
        private IBFreeContext db = new IBFreeContext();

        // GET: api/BigViewModels
        public IQueryable<BigViewModel> GetBigViewDb()
        {
            return db.BigViewDb;
        }

        // GET: api/BigViewModels/5
        [ResponseType(typeof(BigViewModel))]
        public IHttpActionResult GetBigViewModel(int id)
        {
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            if (bigViewModel == null)
            {
                return NotFound();
            }

            return Ok(bigViewModel);
        }

        // PUT: api/BigViewModels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBigViewModel(int id, BigViewModel bigViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bigViewModel.ImputId)
            {
                return BadRequest();
            }

            db.Entry(bigViewModel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BigViewModelExists(id))
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

        // POST: api/BigViewModels
        [ResponseType(typeof(BigViewModel))]
        public IHttpActionResult PostBigViewModel(BigViewModel bigViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BigViewDb.Add(bigViewModel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bigViewModel.ImputId }, bigViewModel);
        }

        // DELETE: api/BigViewModels/5
        [ResponseType(typeof(BigViewModel))]
        public IHttpActionResult DeleteBigViewModel(int id)
        {
            BigViewModel bigViewModel = db.BigViewDb.Find(id);
            if (bigViewModel == null)
            {
                return NotFound();
            }

            db.BigViewDb.Remove(bigViewModel);
            db.SaveChanges();

            return Ok(bigViewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BigViewModelExists(int id)
        {
            return db.BigViewDb.Count(e => e.ImputId == id) > 0;
        }
    }
}