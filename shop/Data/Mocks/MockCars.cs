using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Data.Mocks
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
                new Car
                    {
                    name = "Tesla 1",
                    shortDesc = "элекктрокар",
                    longDesc = "фывоатфыовтафывтафшв",
                    img = "",
                    price = 45000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.ElementAt(1)
                    },
                new Car
                    {
                    name = "Ford Fiesta",
                    shortDesc = "dsfasdfasdfadf",
                    longDesc = "ASDasdasdSAFDASDFASDF",
                    img = "",
                    price = 11000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.ElementAt(2)
                    },
                new Car
                    {
                    name = "BMW M3",
                    shortDesc = "123534251345",
                    longDesc = "2345132431241",
                    img = "",
                    price = 65000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.ElementAt(2)
                    },
                new Car
                    {
                    name = "Mercedes E class",
                    shortDesc = "3q4341aerasdf32",
                    longDesc = "54h7geatrb54uhp9g",
                    img = "",
                    price = 40000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.ElementAt(2)
                    },
                new Car
                    {
                    name = "Nissan Leaf",
                    shortDesc = "drstoj49258yt0g87h2",
                    longDesc = "w45yw45yhw",
                    img = "",
                    price = 14000,
                    isFavourite = true,
                    available = true,
                    Category = _categoryCars.AllCategories.ElementAt(1)
                    }
                };
            }  
        }
        public IEnumerable<Car> getFavCars { get ; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
