using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grroup3Consoole2
{
    internal class Person
    {
        public Person(string emri, string mbiemri)
        {
            Emri = emri;
            Mbiemri = mbiemri;
        }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        //fjala virtual nenkupton qe kjo metode duhet te kete
        //implemntime te ndryshme ne klasa specifike(studednt, profesor)
        public virtual void Pershendete()
        {
            Console.WriteLine($"Pershendetje njeri {Emri},{Mbiemri}");
        }

    }
}
