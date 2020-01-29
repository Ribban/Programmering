using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition1
{
    class Person
    {
        private string Förnamn;
        private string Efternamn;
        public string GetFullName()
        {
            return Förnamn + Efternamn;
        }
    }
}
