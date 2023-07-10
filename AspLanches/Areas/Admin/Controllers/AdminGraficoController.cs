﻿using AspLanches.Areas.Admin.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace AspLanches.Areas.Admin.Controllers
{
    public class AdminGraficoController : Controller
    {

        private readonly GraficoVendasService _graficoVendasService;

        public AdminGraficoController(GraficoVendasService graficoVendasService)
        {
            _graficoVendasService = graficoVendasService;
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendasService.GetVendasLanches(dias);
            return Json(lanchesVendasTotais);
        }

        // Calcula as vendas dos últimos 360 dias
        public IActionResult Index(int dias)
        {
            return View();
        }

        // Calculas as vendas dos últimos 30 dias
        public IActionResult VendasMensal(int dias)
        {
            return View();
        }

        // Calculas as vendas dos últimos 7 dias
        public IActionResult VendasSemanal(int dias)
        {
            return View();
        }
    }
}