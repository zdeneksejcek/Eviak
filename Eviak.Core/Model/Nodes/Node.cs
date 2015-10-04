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
        public SysName Name { get; private set; }
        public Node Parent { get; private set; }

        public Node(SysName name, Node parent)
        {
            this.Name = name;
            this.Parent = parent;
        }
    }
}