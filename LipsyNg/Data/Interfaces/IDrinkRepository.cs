using LipsyNg.Data.Models;
using System.Collections.Generic;

namespace LipsyNg.Data.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferredDrinks { get; set; }
        Drink GetDrinkById(int drinkId);
    }
}
