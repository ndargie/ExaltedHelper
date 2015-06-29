using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaltedHelper.Infrastructure.Interfaces
{
    public interface ICharmCost
    {
        int Willpower { get; set; }
        int Essance { get; set; }
        int Health { get; set; }
    }
}
