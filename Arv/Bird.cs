using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Bird : Animal
    {
        public Bird(string name)
        {
            Name = name;
            Species = 2;
            CanFly = true;
        }
    }
}
