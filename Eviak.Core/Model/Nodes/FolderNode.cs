﻿using Eviak.Core.Model.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    public class FolderNode : Node
    {
        public FolderNode(SysName name, Node parent) : base(name, parent)
        {

        }
    }
}