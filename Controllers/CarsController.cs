using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;

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
            var cars = allCars.Cars;
            return View(cars);
        }
    }
}
