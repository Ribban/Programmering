using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1___Simmare
{
    class Program
    {
        static void Main(string[] args)
        {
            SwimmerTest(args);
        }
        public static void SwimmerTest(string[] args)
        {
            Swimmer johan = new Swimmer("Johan");
            Swimmer magnus = new Swimmer("Magnus", new BathingSuit());
            johan.SetSuit(new BathingSuit());
            magnus.SetSuit(null);
            ProfessionalSwimmer eric = new ProfessionalSwimmer("Eric", new BathingSuit());
            ProfessionalSwimmer simon = new ProfessionalSwimmer("Simon");
            eric.SetSuit(null);
            List<Swimmer> swimmers = new List<Swimmer>();
            swimmers.Add(johan);
            swimmers.Add(new YoungSwimmer("Christoffer", new BathingSuit()));
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }
            foreach (Swimmer sw in swimmers)
            {
                sw.Swim();
            }
        }
    }
}
