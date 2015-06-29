using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaltedHelper.Infrastructure.Interfaces
{
    public interface ICharm
    {
        string Name { get; set; }
        ICharmCost cost { get; set; }
        string Description { get; set; }
        bool ComboOk { get; set; }

        bool SaveCharm();
    }
}
