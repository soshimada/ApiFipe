using ApiFipe.Domain.Model;
using ApiFipe.Service.Service;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;
using System.Net;
using System.IO;
using System.Web.Http.Cors;

namespace ApiFipe.Controllers
{

    public class HomeController : ApiController
    {
        FipeService srv = new FipeService();

        [Route("BuscarTodos")]
        [HttpGet]
        public IHttpActionResult BuscarTodos()
        {
     
            return Ok(srv.List());
        }
        [Route("AtualizarFipe")]
        [HttpGet]
        public IHttpActionResult AtualizarFipe(Fipe fipe)
        {
            srv.Update(fipe);
            return Ok("");
        }
        [Route("Delete")]
        [HttpGet]
        public IHttpActionResult Delete(int id)
        {
            srv.Delete(id);
            return Ok("");
        }
        [Route("BuscarPorId")]
        [HttpGet]
        public IHttpActionResult BuscarPorId(int id)
        {
            return Ok(srv.Get(id));
        }
        [Route("Inserir")]
        [HttpGet]
        public IHttpActionResult Inserir(Fipe fipe)
        {
            srv.Add(fipe);
            return Ok("");
        }

        [HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/BuscarPorAno")]
        public IHttpActionResult BuscarPorAno(Fipe fipe)       
        {
            return Ok(srv.BuscarPorAno(fipe.Ano));       
        }       


    }
   
}
