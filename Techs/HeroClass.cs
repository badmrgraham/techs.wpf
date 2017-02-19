using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Techs
{
    public class HeroClass
    {
        public List<Ability> Abilities { get; set; }
        public string Name { get; set; }

        public HeroClass()
        {
            Name = string.Empty;
        }
    }
}
