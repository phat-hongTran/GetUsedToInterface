﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUsedToInterface
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }
}
