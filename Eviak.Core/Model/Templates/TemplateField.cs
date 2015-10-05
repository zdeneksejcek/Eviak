using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Templates
{
    public class TemplateField
    {
        public SysName Name { get; private set; }

        public Type Type { get; private set; }

        public TemplateField(SysName name, Type fieldType)
        {
            this.Name = name;
            this.Type = fieldType;
        }
    }
}