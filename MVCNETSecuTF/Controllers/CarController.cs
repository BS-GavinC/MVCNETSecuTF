using Microsoft.AspNetCore.Mvc;
using MVCNETSecuTF.Context;
using MVCNETSecuTF.Models;

namespace MVCNETSecuTF.Controllers;

public class CarController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View(FakeDb.GetCars());
    }

    public IActionResult Detail(int id)
    {
        Car? car = FakeDb.GetById(id);
        if (car is not null)
        {
            return View(car);
        }

        return RedirectToAction("NotFound");
    }

    public IActionResult Delete(int id)
    {
        FakeDb.RemoveCar(id);
        return RedirectToAction("index");
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Car car)
    {
        if (ModelState.IsValid)
        {
            FakeDb.AddCar(car);
            return RedirectToAction("Index");
        }
        return View(car);
    }

    public IActionResult Update(int id)
    {
        Car? carToUpdate = FakeDb.GetById(id);
        if (carToUpdate is not null)
        {
            return View(carToUpdate);
        }

        return RedirectToAction("NotFound");

    }

    [HttpPost]
    public IActionResult Update(Car car)
    {
        if (ModelState.IsValid)
        {
            FakeDb.UpdateCar(car);
            return RedirectToAction("Index");
        }

        return View(car);
    }

    public IActionResult NotFound()
    {
        return View();
    }
}