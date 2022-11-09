using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klase_i_objekti_pon
{
    class Program
    {
        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            public override string ToString()
            {
                return "Stablo je " + this.vrstaStabla;
            }
            
            public void SetOtpadajuListovi(bool otpadajuListovi)
            {
                this.otpadajuListovi = otpadajuListovi;
            }


            
            public bool getOtpadajuListovi()
            {
                return this.otpadajuListovi;

            }



            public Stablo()
            {
            }
            public Stablo(bool otpadajuListovi)
            {
                this.otpadajuListovi = otpadajuListovi;
                if (otpadajuListovi)
                {
                    this.vrstaStabla = "Bijelogorično";
                }
                else
                {
                    this.vrstaStabla = "Crnogorično";
                }
            }
        }


        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);

            Console.WriteLine("Stablo 1: " + stablo1.ToString());
            Console.WriteLine("Stablo 2: " + stablo2.ToString());

            Console.ReadKey();
        }
    }
}
