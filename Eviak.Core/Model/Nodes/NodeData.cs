using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Eviak.Core.Model.Nodes
{
    internal class NodeData : Dictionary<string, string>
    {
        public NodeData() { }

        public NodeData(XmlReader xml)
        {
            
        }
    }
}