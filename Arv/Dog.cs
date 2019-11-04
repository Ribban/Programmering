using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            Name = name;
            Species = SPECIES.DOG;
            CanFly = false;
        }
    }
}
