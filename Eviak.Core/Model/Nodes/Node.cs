using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    public abstract class Node
    {
        private NodeContent Content { get; set; }

        public Id Id {
            get {
                return Content.Get<Id>(
                    new FieldName(FieldName.Id));
            }
        }

        public SysName Name
        {
            get
            {
                return Content.Get<SysName>(
                    new FieldName(FieldName.Id));
            }
        }

        public T GetValue<T>()
        {
            return default(T);
        }

        public Node(SysName name)
        {
            this.Content = new NodeContent();
        }

        public Node(NodeContent content)
        {

        }
    }
}