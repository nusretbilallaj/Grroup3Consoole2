using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grroup3Consoole2
{
    internal class Studenti:Person
    {
        public Studenti(string emri, string mbiemri, string adre):base(emri,mbiemri)
        {
            Adresa= adre;
        }

        public string Adresa { get; set; }

        //Klasat specifike te cilat i implemtojne metoda specifike
        //psh profesori pershendetje profesor 
        //duhet ta perdorin fjalen e rezervuar override
        public override void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta student: {Emri} {Mbiemri} nga {Adresa}");
        }

    }
}
