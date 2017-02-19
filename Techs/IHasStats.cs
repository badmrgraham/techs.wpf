using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Techs
{
    interface IHasStats
    {
        int Tech { get; set; }
        int Faith { get; set; }
        int Strength { get; set; }
        int Body { get; set; }
        int Speed { get; set; }
    }
}
