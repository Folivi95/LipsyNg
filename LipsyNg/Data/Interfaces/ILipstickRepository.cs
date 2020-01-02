using LipsyNg.Data.Models;
using System.Collections.Generic;

namespace LipsyNg.Data.Interfaces
{
    public interface ILipstickRepository
    {
        IEnumerable<Lipsticks> Lipsticks { get; }
        IEnumerable<Lipsticks> PreferredLipsticks { get; }
        Lipsticks GetLipstickById(int LipstickId);
    }
}
