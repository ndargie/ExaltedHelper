using ExaltedHelper.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExaltedHelper.Infrastructure.Implementations
{
    public class DbAccessor : IDbAccessor
    {
        public IEnumerable<ICharm> GetCharms()
        {
            throw new NotImplementedException();
        }

        public bool SaveCharm(ICharm charm)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCharm(ICharm charm)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCharm(ICharm charm)
        {
            throw new NotImplementedException();
        }

        public ICharm FindCharm(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}