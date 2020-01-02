using LipsyNg.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipsyNg.ViewModels
{
    public class LipstickListViewModel
    {
        public IEnumerable<Lipsticks> Lipsticks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
