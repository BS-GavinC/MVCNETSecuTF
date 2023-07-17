using Microsoft.AspNetCore.Mvc;
using MVCNETSecuTF.Models.Forms;

namespace MVCNETSecuTF.Controllers;

public class CarController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateCarForm form)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("index");
        }
        Console.WriteLine(ModelState.IsValid);
        foreach (var Model in ModelState)
        {
            foreach (var error in Model.Value.Errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }
        }
        
        return View(form);
    }
    
}