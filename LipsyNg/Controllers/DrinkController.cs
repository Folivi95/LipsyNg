using LipsyNg.Data.Interfaces;
using LipsyNg.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LipsyNg.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ILipstickRepository drinkRepository;

        public DrinkController(ICategoryRepository category, ILipstickRepository drink)
        {
            categoryRepository = category;
            drinkRepository = drink;
        }

        public ViewResult List()
        {
            DrinkListViewModel vm = new DrinkListViewModel();
            vm.Drinks = drinkRepository.Drinks;
            vm.CurrentCategory = "Drink Category";
            return View(vm);
        }
    }
}
