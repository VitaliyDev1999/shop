using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Interfaces;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "Tesla",
                        shortDesc = "удобная и єкономная",
                        longDesc = "удобная и єкономная , только для городского передвижения",
                        price = 45000,
                        img = "/img/tesla.jpg",
                        isFavourite = true,
                        available = true,
                        Categoty = _categoryCars.AllCateories.First()},
                    new Car {
                        name = "BMW",
                        shortDesc = "удобная , спортивная",
                        longDesc = "удобная машина, но потребляет много бензина",
                        price = 35000,
                        img = "/img/bmw.jpg",
                        isFavourite = true,
                        available = true,
                        Categoty = _categoryCars.AllCateories.Last() },
                    new Car {
                        name = "Mercedes",
                        shortDesc = "удобная машина бизнес класса",
                        longDesc = "удобная машина, но потребляет много бензина",
                        price = 35000,
                        img = "/img/mercedes.jpg",
                        isFavourite = true,
                        available = true,
                        Categoty = _categoryCars.AllCateories.Last() }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
