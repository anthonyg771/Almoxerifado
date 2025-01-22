using AlmoxerifadoAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AlmoxerifadoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly List<Categoria> _categorias;
        public CategoriaController() 
        {

        }
        [HttpGet(Name = "lista")]
        public ActionResult<Categoria> GetCategorias()
        {
            _categorias = new List<Categoria>()
            new Categoria
            {
                Codigo = 1,
                Descricao = "Alimentos"
            },
            new Categoria()
            {
                Codigo = 2,
                Descricao = "Bebidas"
            }
        };
        return Ok(_categorias);
            
        
      

           
    }
}
