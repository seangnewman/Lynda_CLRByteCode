﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface ICallMe
    {
         string Name { get;  }
        void CallMe();
    }
}
