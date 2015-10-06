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
        private VersionedVariantData Data { get; set; }

        internal T Get<T>(FieldName name)
        {
            

            return default(T);
        }

        internal void Set<T>(FieldName name, T value)
        {
            //this.Data[name] = value.ToString();
        }

        internal NodeContent()
        {
            //this.Data = new NodeData();
        }

        internal NodeContent(VersionedVariantData data, NodeMeta meta)
        {
            this.Data = data;
            this.Meta = meta;
        }
    }
}