using Eviak.Core.Model.Nodes;
using Eviak.Core.Model.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = TreeBuilder.Build(null);
        }
    }
}