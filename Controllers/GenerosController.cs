using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OutputCaching;
using PeliculasApi.Entidades;

namespace PeliculasApi.Controllers
{

    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        
        private readonly IOutputCacheStore outputCacheStore;
        private readonly ApplicationDbContext context;
        private readonly IConfiguration configuration;
        private const string cacheTag = "generos";
        public GenerosController(IOutputCacheStore outputCacheStore, ApplicationDbContext context)
        {
           
            this.outputCacheStore = outputCacheStore;
            this.context = context;
        }
        
        [HttpGet] //api/generos
        [OutputCache(Tags = [cacheTag])]
        public List<Genero> Get()
        {
            return new List<Genero>() { new Genero { Id=1, Nombre = "Comedia"},
             new Genero { Id=2, Nombre = "Acción"}};
            
        }
        [HttpGet("{id:int}",Name = "ObtenerGeneroPorId")]
         [OutputCache(Tags = [cacheTag])]
        public async Task<ActionResult<Genero>> Get(int id)
        {
            
            throw new NotImplementedException();
        }


  
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Genero genero)
        {
            context.Add(genero);
            await context.SaveChangesAsync();
            return CreatedAtRoute("ObtenerGeneroPorId",new {id = genero.Id},genero);

        }
        [HttpPut]
        public void Put()
        {
            throw new NotImplementedException();
        }
        [HttpDelete]
        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}