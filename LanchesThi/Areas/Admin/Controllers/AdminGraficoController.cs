using LanchesThi.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanchesThi.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {

        private readonly GraficoVendasService _graficoVendas;

        public AdminGraficoController(GraficoVendasService graficoVendas)
        {
            _graficoVendas = graficoVendas;
        }   

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanche(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }

    }
}
