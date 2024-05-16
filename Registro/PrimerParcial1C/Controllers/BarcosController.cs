
using Microsoft.AspNetCore.Mvc;
using PrimerParcial1C.Servicios;
using PrimerParcial1C.Models;

using System.Collections.Generic;

public class BarcosController : Controller
{
    private readonly IBarcoService _barcoService;

    public BarcosController(IBarcoService barcoService)
    {
        _barcoService = barcoService;
    }

    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Registrar(BarcoModel barco)
    {
        if (ModelState.IsValid)
        {
            _barcoService.RegistrarBarco(barco);
            return RedirectToAction("Listar");
        }
        return View(barco);
    }

    public IActionResult Listar()
    {
        var barcos = _barcoService.ObtenerBarcos();
        return View(barcos);
    }
}
