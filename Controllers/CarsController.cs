using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategory;

        public CarsController(IAllCars iAllCars,ICarsCategory iCarsCategory)
        {
            allCars = iAllCars;
            carsCategory = iCarsCategory;
        }

        public ViewResult List()
        {
            //ViewBag.Category = "Some new";
            //var cars = allCars.Cars;
            ViewBag.Title = "Страница с автомобилями";
            CarListViewModel cars = new CarListViewModel();
            cars.allCars = allCars.Cars;
            cars.currCategory = "Автомобили";
            return View(cars);
        }
    }
}
