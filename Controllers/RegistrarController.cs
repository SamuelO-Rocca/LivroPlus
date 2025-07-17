using Livro.Models;
using Microsoft.AspNetCore.Mvc;

public class RegistrarController : Controller
{
    public IActionResult Registrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Registrar(RegistrarModel model)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Dashboard", "Home");
        }

        return View(model); // <- retorna a mesma view se model inválido
    }
}
