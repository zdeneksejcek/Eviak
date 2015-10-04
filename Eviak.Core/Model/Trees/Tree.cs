using Eviak.Core.Model.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Trees
{
    public class Tree
    {
        public RootNode Root { get; private set; }

        public Tree(RootNode root) {
            this.Root = root;
        }
    }
}