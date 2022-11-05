using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grroup3Consoole2
{
    internal class Profesori:Person
    {
        public Profesori(string emri, string mbiemri):base(emri,mbiemri)
        {
        }


        public override void Pershendete()
        {
            Console.WriteLine($"Tungjatjeta profesor {Emri}, {Mbiemri}");
        }
    }
}
