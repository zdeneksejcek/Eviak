using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eviak.Core.Model.Fields;

namespace Eviak.Core.Model.Templates
{
    public class BaseTemplate : Template
    {
        protected override SysName Name
        {
            get
            {
                return new SysName("BaseTemplate");
            }
        }

        protected override IEnumerable<TemplateField> GetFields()
        {
            yield return new TemplateField("Id", typeof(IdField));
            yield return new TemplateField("Name", typeof(SysNameField));
        }
    }
}