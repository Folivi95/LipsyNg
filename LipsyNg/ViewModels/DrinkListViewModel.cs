﻿using LipsyNg.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LipsyNg.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Lipsticks> Drinks { get; set; }
        public string CurrentCategory { get; set; }
    }
}
