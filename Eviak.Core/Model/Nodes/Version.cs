﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Nodes
{
    public class Version
    {
        public int Number { get; private set; }

        public Version(int number)
        {
            Number = number;
        }
    }
}
