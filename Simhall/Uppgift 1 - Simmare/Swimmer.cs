using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1___Simmare
{
    class Swimmer
    {
        private string Name;
        private BathingSuit Suit;
        public Swimmer(string Name, BathingSuit Suit)
        {
            this.Name = Name;
            this.Suit = Suit;
        }
        public string Swim()
        {
            return "Splish splash - it's so fun in the bath!";
        }
        public void Setsuit(BathingSuit Suit)
        {
            this.Suit = Suit;
        }
    }
    class BathingSuit
    {

    }
    class ProfessionalSwimmer
    {
        public void SetSuit(BathingSuit Suit)
        {

        }
    }
    class YoungSwimmer
    {
        private bool Tired;
        public string Swim()
        {
            return "I'm so tired - time to get out";
        }
    }
}