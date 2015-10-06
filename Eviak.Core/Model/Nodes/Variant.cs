using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    public class Variant
    {
        public string Value { get; private set; }

        public Variant(string value)
        {
            Value = value;
        }
    }
}
