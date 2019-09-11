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
using FinalProjectWEBAPI.Models;

namespace FinalProjectWEBAPI.Controllers
{
    public class TermoDeUsoesController : ApiController
    {
        private ContextDb db = new ContextDb();

        // GET: api/TermoDeUsoes
        public IQueryable<TermoDeUso> GetTermoDeUsos()
        {
            return db.TermoDeUsos;
        }

        // GET: api/TermoDeUsoes/5
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> GetTermoDeUso(int id)
        {
            TermoDeUso termoDeUso = await db.TermoDeUsos.FindAsync(id);
            if (termoDeUso == null)
            {
                return NotFound();
            }

            return Ok(termoDeUso);
        }

        // PUT: api/TermoDeUsoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermoDeUso(int id, TermoDeUso termoDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termoDeUso.IdTermo)
            {
                return BadRequest();
            }

            db.Entry(termoDeUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermoDeUsoExists(id))
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

        // POST: api/TermoDeUsoes
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> PostTermoDeUso(TermoDeUso termoDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var validaTermo = db.TermoDeUsos.FirstOrDefault(x => x.Vigente == true);
            if (validaTermo != null)
                validaTermo.Vigente = false;

            db.TermoDeUsos.Add(termoDeUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termoDeUso.IdTermo }, termoDeUso);
        }

        // DELETE: api/TermoDeUsoes/5
        [ResponseType(typeof(TermoDeUso))]
        public async Task<IHttpActionResult> DeleteTermoDeUso(int id)
        {
            TermoDeUso termoDeUso = await db.TermoDeUsos.FindAsync(id);
            if (termoDeUso == null)
            {
                return NotFound();
            }

            db.TermoDeUsos.Remove(termoDeUso);
            await db.SaveChangesAsync();

            return Ok(termoDeUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermoDeUsoExists(int id)
        {
            return db.TermoDeUsos.Count(e => e.IdTermo == id) > 0;
        }
    }
}