using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;

namespace shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

       

        public CarsController(IAllCars iAllcars, ICarsCategory iCarsCat)
        {
            _allCars = iAllcars;
            _allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
