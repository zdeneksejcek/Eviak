using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Templates
{
    public abstract class Template
    {
        protected abstract SysName Name { get; }

        protected abstract IEnumerable<TemplateField> GetFields();
    }
}