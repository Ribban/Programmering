using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism_Abstract
{
    class Supa
    {
        public void Dricka()
        {
            Console.WriteLine("Dags att supa");
        }
    }
    class Hotellet : Supa
    {
        public void Dricka()
        {
            Console.WriteLine("Dags att supa på hotellet");
        }
    }
    class Hemma : Supa
    {
        public void Dricka()
        {
            Console.WriteLine("Dags att supa hemma");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Supa> alkolister = new List<Supa>();

            alkolister.Add(new Supa());
            alkolister.Add(new Hotellet());
            alkolister.Add(new Hemma());
            foreach (Supa s in alkolister)
            {
                s.Dricka();
            }
        }
    }
}
