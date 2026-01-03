using Microsoft.AspNetCore.Mvc;

namespace sistemamercado.Controllers
{

    [Route("produtos")]
    public class ProdutosController : Controller
    {
        string nome = "Rota de Produtos funcionando";
        public IActionResult Index()
        {
            return Content(nome);
        }
    }
}
