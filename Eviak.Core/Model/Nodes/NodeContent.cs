using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    public class NodeContent
    {
        private NodeMeta Meta { get; set; }

        protected T Get<T>(FieldName name)
        {
            return default(T);
        }

        internal NodeContent(Id id, SysName name)
        {
            
        }

        internal NodeContent()
        {
            
        }
    }
}