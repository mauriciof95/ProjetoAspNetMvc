using Microsoft.AspNetCore.Mvc;
using ProjetoAspNet.Models;
using System.Numerics;
using System.Reflection;

namespace ProjetoAspNet.Controllers
{
    public class FatorialController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Resultado()
        {
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Resultado(FatorialModel fatorial)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", fatorial);
            }

                    
            ViewBag.ValorOriginal = fatorial.Numero;
            ViewBag.ResultadoFatorial = calcularFatorial((int) fatorial.Numero);
            return View();
        }

        private string calcularFatorial(int numero)
        {
            if (numero == 0) return "1";

            BigInteger resultado = 1;
            for (long i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            if(numero > 25)
            {
                string notacaoCientifica = resultado.ToString("E");

                string[] partes = notacaoCientifica.Split('+');
                string valor = partes[0];
                string expoente = partes[1];


                return $"{valor.Replace("E", " × 10")}{FormatoExpoente(expoente)}";
            }


            return  resultado.ToString("#,##0", System.Globalization.CultureInfo.GetCultureInfo("pt-BR")); ;
        }

        private string FormatoExpoente(string valor)
        {
            var expoentes = "⁰¹²³⁴⁵⁶⁷⁸⁹";

            valor = long.Parse(valor).ToString();
            
            var valorComoExpoente = "";

            for (int i = 0; i < valor.Length; i++)
            {
                int j = (int) char.GetNumericValue(valor[i]);

                valorComoExpoente += expoentes[j];
            }

            return valorComoExpoente;
        }
    }
}
