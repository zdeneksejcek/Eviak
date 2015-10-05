using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Fields
{
    public class SysName : Field
    {
        public string Value { get; private set; }

        public SysName(string value)
        {
            this.Value = value;
        }

        public static implicit operator SysName(string value)
        {
            return new SysName(value);
        }

        public static implicit operator string(SysName name)
        {
            return name.Value;
        }

    }
}
