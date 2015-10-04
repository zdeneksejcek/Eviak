﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eviak.Core.Model.Fields
{
    public class SysName : Field
    {
        public string Name { get; private set; }

        public SysName(string name)
        {
            this.Name = name;
        }
    }
}
