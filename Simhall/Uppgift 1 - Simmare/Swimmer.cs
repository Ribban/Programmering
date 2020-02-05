using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1___Simmare
{
    class Swimmer
    {
        private string name { get; set; }
        private BathingSuit suit { get; set; }
        public Swimmer(string name, BathingSuit suit)
        {
            this.name = name;
            this.suit = suit;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSuit(BathingSuit suit)
        {
            if(suit != null)
            {
                this.suit = suit;
            }
        }
        public virtual string Swim()
        {
            return "Splish splash - it's so fun in the bath!";
        }
        public void Setsuit(BathingSuit suit)
        {
            this.suit = suit;
        }
    }
    class BathingSuit
    {

    }
    class ProfessionalSwimmer : Swimmer
    {
        public ProfessionalSwimmer(string name, BathingSuit suit) : base(name, suit)
        {
            SetName(name);
            SetSuit(suit);
        }
    }
    class YoungSwimmer : Swimmer
    {
        public YoungSwimmer(string name, BathingSuit suit) : base(name, suit)
        {
            SetName(name);
            SetSuit(suit);
        }
        public void SetTired()
        {
            tired = true;
        }
        public override string Swim()
        {
            if(!tired)
            {
                SetTired();
                return "Splish splash - it's so fun in the bath!";
            }
        }
        private bool tired;
    }
}