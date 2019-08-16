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
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    /*
    A classe WebApiConfig pode requerer alterações adicionais para adicionar uma rota para esse controlador. Misture essas declarações no método Register da classe WebApiConfig conforme aplicável. Note que URLs OData diferenciam maiúsculas e minúsculas.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using WebAPI.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Marca>("Marcas");
    builder.EntitySet<Carro>("Carros"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class MarcasController : ODataController
    {
        private LocacaoDB db = new LocacaoDB();

        // GET: odata/Marcas
        [EnableQuery]
        public IQueryable<Marca> GetMarcas()
        {
            return db.Marcas;
        }

        // GET: odata/Marcas(5)
        [EnableQuery]
        public SingleResult<Marca> GetMarca([FromODataUri] int key)
        {
            return SingleResult.Create(db.Marcas.Where(marca => marca.Id == key));
        }

        // PUT: odata/Marcas(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Marca> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Marca marca = db.Marcas.Find(key);
            if (marca == null)
            {
                return NotFound();
            }

            patch.Put(marca);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(marca);
        }

        // POST: odata/Marcas
        public IHttpActionResult Post(Marca marca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Marcas.Add(marca);
            db.SaveChanges();

            return Created(marca);
        }

        // PATCH: odata/Marcas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Marca> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Marca marca = db.Marcas.Find(key);
            if (marca == null)
            {
                return NotFound();
            }

            patch.Patch(marca);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MarcaExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(marca);
        }

        // DELETE: odata/Marcas(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Marca marca = db.Marcas.Find(key);
            if (marca == null)
            {
                return NotFound();
            }

            db.Marcas.Remove(marca);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Marcas(5)/Carros
        [EnableQuery]
        public IQueryable<Carro> GetCarros([FromODataUri] int key)
        {
            return db.Marcas.Where(m => m.Id == key).SelectMany(m => m.Carros);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MarcaExists(int key)
        {
            return db.Marcas.Count(e => e.Id == key) > 0;
        }
    }
}
