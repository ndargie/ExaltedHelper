using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Infrastructure.Interfaces
{
    public interface IDbAccessor
    {
        IEnumerable<ICharm> GetCharms();
        bool SaveCharm(ICharm charm);
        bool DeleteCharm(ICharm charm);
        bool UpdateCharm(ICharm charm);
        ICharm FindCharm(Guid id);
    }
}