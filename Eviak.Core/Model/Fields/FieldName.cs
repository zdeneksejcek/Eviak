using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Fields
{
    public sealed class FieldName : SysName
    {
        public FieldName(string fieldName) : base(fieldName)
        {

        }

        public const string Id = "__id";
        public const string Name = "__name";
    }
}