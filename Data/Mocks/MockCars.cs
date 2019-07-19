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
                        img = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwiDwOOa6sHjAhXPw6YKHTiPDCEQjRx6BAgBEAU&url=https%3A%2F%2Fbgr.com%2F2019%2F01%2F14%2Ftesla-roadster-pictures-2020-design-sleek%2F&psig=AOvVaw1ZUshSBdhbzoz9_kM7IDsS&ust=1563654804171363",
                        isFavourite = true,
                        available = true,
                        Categoty = _categoryCars.AllCateories.First()},
                    new Car {
                        name = "BMW",
                        shortDesc = "удобная , спортивная",
                        longDesc = "удобная машина, но потребляет много бензина",
                        price = 35000,
                        img = "https://www.google.com/url?sa=i&source=images&cd=&ved=2ahUKEwjuy6nm6sHjAhWl1aYKHW8mA24QjRx6BAgBEAU&url=https%3A%2F%2Flink.photo%2Fimage%2FHekS&psig=AOvVaw0kb67M784wtD4mRuB9ypw7&ust=1563654957036827",
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
