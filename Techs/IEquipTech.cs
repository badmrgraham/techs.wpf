using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Techs
{
    interface IEquipTech
    {
        TechItem Offensive { get; set; }
        TechItem Defensive { get; set; }
    }
}
