using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Электромобили", desc = "Соверменный вид транспорта"},
                    new Category {categoryName = "Классические автомобили", desc = "Машиныт с двигателем внутреннего сгорания"}
                };
            }
        }
    }
}
