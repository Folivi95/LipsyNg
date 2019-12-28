using LipsyNg.Data.Interfaces;
using LipsyNg.Data.Models;
using System.Collections.Generic;

namespace LipsyNg.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category> {
                    new Category { CategoryName="Alcoholic", Description="All alcoholic drinks"},
                    new Category { CategoryName="Non-alcoholic", Description="All non-alcoholic drinks"}
                };
            }
        }
    }
}
