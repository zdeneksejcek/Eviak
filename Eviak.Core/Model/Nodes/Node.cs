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

        public Id Id { get; private set; }

        public SysName Name { get; private set; }

        public Node(SysName name)
        {
            this.Content = new NodeContent();
            this.Name = name;
        }

        public Node(NodeContent content)
        {
            
        }
    }
}