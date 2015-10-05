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
        private NodeData Data { get; set; }

        internal T Get<T>(FieldName name)
        {
            var value = this.Data[name];

            return default(T);
        }

        internal void Set<T>(FieldName name, T value)
        {
            this.Data[name] = value.ToString();
        }

        internal NodeContent()
        {
            this.Data = new NodeData();
        }

        internal NodeContent(NodeData data, NodeMeta meta)
        {
            this.Data = data;
            this.Meta = meta;
        }
    }
}