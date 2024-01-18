using Microsoft.AspNetCore.Mvc;
using ProjetoAspNet.Database;
using ProjetoAspNet.Models;

namespace ProjetoAspNet.Controllers
{
    public class PessoaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PessoaModel pessoa)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", pessoa );
            }
            ListaPessoa.AdicionarPessoa(pessoa);

            var lista = ListaPessoa.RecuperarLista().Where(x => x.Idade > 30).ToList();
            ViewBag.ListaPessoa = lista;

            return View();
        }
    }
}
