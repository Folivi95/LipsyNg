using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LipsyNg.Data.Interfaces;
using LipsyNg.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LipsyNg.Data.Repositories
{
    public class LipstickRepository : ILipstickRepository
    {
        private readonly AppDbContext appDbContext;
        public LipstickRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Lipsticks> Lipsticks => appDbContext.Lipsticks.Include(c => c.Category);
        public IEnumerable<Lipsticks> PreferredLipsticks { get => appDbContext.Lipsticks.Where(p => p.IsPreferredLipstick).Include(c => c.Category);  }

        public Lipsticks GetLipstickById(int LipstickId)
        {
            return appDbContext.Lipsticks.FirstOrDefault(p => p.LipstickId == LipstickId);
        }
    }
}
