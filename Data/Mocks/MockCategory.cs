using System;
using System.Collections.Generic;
using System.Linq;
using Shop.Data.Interfaces;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCateories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName="Electro Cars", desc="Машини искользующие акамуляторы для передвижения"},
                    new Category { categoryName = "Benz Cars", desc = "Машини искользующие топливо для передвижения" }
                };
            }
        }
    }
}
