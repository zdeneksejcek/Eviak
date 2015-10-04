using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Fields
{
    public class Id
    {
        public Guid Guid { get; private set; }

        public Id(Guid guid)
        {
            this.Guid = guid;
        }

        public static Id New()
        {
            return new Id(Guid.NewGuid());
        }
    }
}
