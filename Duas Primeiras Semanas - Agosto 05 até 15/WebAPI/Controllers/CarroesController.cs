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
    builder.EntitySet<Carro>("Carroes");
    builder.EntitySet<Marca>("Marcas"); 
    builder.EntitySet<Venda>("Vendas"); 
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CarroesController : ODataController
    {
        private LocacaoDB db = new LocacaoDB();

        // GET: odata/Carroes
        [EnableQuery]
        public IQueryable<Carro> GetCarroes()
        {
            return db.Carros;
        }

        // GET: odata/Carroes(5)
        [EnableQuery]
        public SingleResult<Carro> GetCarro([FromODataUri] int key)
        {
            return SingleResult.Create(db.Carros.Where(carro => carro.Id == key));
        }

        // PUT: odata/Carroes(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Carro> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Carro carro = db.Carros.Find(key);
            if (carro == null)
            {
                return NotFound();
            }

            patch.Put(carro);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(carro);
        }

        // POST: odata/Carroes
        public IHttpActionResult Post(Carro carro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Carros.Add(carro);
            db.SaveChanges();

            return Created(carro);
        }

        // PATCH: odata/Carroes(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Carro> patch)
        {
            Validate(patch.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Carro carro = db.Carros.Find(key);
            if (carro == null)
            {
                return NotFound();
            }

            patch.Patch(carro);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarroExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Updated(carro);
        }

        // DELETE: odata/Carroes(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            Carro carro = db.Carros.Find(key);
            if (carro == null)
            {
                return NotFound();
            }

            db.Carros.Remove(carro);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // GET: odata/Carroes(5)/Marca1
        [EnableQuery]
        public SingleResult<Marca> GetMarca1([FromODataUri] int key)
        {
            return SingleResult.Create(db.Carros.Where(m => m.Id == key).Select(m => m.Marca1));
        }

        // GET: odata/Carroes(5)/Vendas
        [EnableQuery]
        public IQueryable<Venda> GetVendas([FromODataUri] int key)
        {
            return db.Carros.Where(m => m.Id == key).SelectMany(m => m.Vendas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarroExists(int key)
        {
            return db.Carros.Count(e => e.Id == key) > 0;
        }
    }
}
