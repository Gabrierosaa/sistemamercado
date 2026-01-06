using Microsoft.AspNetCore.Mvc;
using sistemamercado.Entities;

namespace sistemamercado.Controllers
{
   

    [Route("produtos")]
    public class ProdutosController : Controller
    {
        string nome = "Rota de Produtos funcionando";
        public List<Produto> Produtos = new List<Produto>();
       
        [HttpGet("VerProduto")]
        public IActionResult verProduto()
        {
            return Ok();
        }
        
    }
}
  