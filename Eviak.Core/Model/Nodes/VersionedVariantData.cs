using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Eviak.Core.Model.Nodes
{
    internal class VersionedVariantData
    {
        public Version Version { get; private set; }

        public Variant Variant { get; private set; }

        public VersionedVariantData(Version version, Variant variant, Dictionary<string, string> data) {

        }

        public VersionedVariantData(XmlReader xml)
        {
            
        }
    }
}