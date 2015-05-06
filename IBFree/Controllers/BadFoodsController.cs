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
    public class BadFoodsController : ApiController
    {
        private IBFreeContext db = new IBFreeContext();

        // GET: api/BadFoods
        public IQueryable<BadFood> GetBadFoods()
        {
            return db.BadFoods;
        }

        // GET: api/BadFoods/5
        [ResponseType(typeof(BadFood))]
        public IHttpActionResult GetBadFood(int id)
        {
            BadFood badFood = db.BadFoods.Find(id);
            if (badFood == null)
            {
                return NotFound();
            }

            return Ok(badFood);
        }

        // PUT: api/BadFoods/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBadFood(int id, BadFood badFood)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != badFood.Id)
            {
                return BadRequest();
            }

            db.Entry(badFood).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BadFoodExists(id))
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

        // POST: api/BadFoods
        [ResponseType(typeof(BadFood))]
        public IHttpActionResult PostBadFood(BadFood badFood)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BadFoods.Add(badFood);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = badFood.Id }, badFood);
        }

        // DELETE: api/BadFoods/5
        [ResponseType(typeof(BadFood))]
        public IHttpActionResult DeleteBadFood(int id)
        {
            BadFood badFood = db.BadFoods.Find(id);
            if (badFood == null)
            {
                return NotFound();
            }

            db.BadFoods.Remove(badFood);
            db.SaveChanges();

            return Ok(badFood);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BadFoodExists(int id)
        {
            return db.BadFoods.Count(e => e.Id == id) > 0;
        }
    }
}