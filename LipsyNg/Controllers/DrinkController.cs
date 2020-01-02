using LipsyNg.Data.Interfaces;
using LipsyNg.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LipsyNg.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ILipstickRepository lipstickRepository;

        public DrinkController(ICategoryRepository category, ILipstickRepository lipstick)
        {
            categoryRepository = category;
            lipstickRepository = lipstick;
        }

        public ViewResult List()
        {
            LipstickListViewModel vm = new LipstickListViewModel();
            vm.Lipsticks = lipstickRepository.Lipsticks;
            vm.CurrentCategory = "Drink Category";
            return View(vm);
        }
    }
}
