using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadetidsSystemet
{
    class Kreds
    {
        //Jeg har valgt at lave auto properties da det er nemmere og ser pænere ud
        public string ID { get; private set; }
        public string Navn { get; private set; }
        public string Adresse { get; private set; }
        public int AntalDeltagere { get; private set; }
        
        public Kreds(string id, string navn, string adresse, int antalDeltagere)
        {
            if(antalDeltagere <= 0)
            {
                throw new ArgumentException("Antal deltagere skal være større end 0");
            }

            ID = id;
            Navn = navn;
            Adresse = adresse;
            AntalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Navn: {Navn}, Adresse: {Adresse}, Antal Deltagere: {AntalDeltagere}";
        }
    }
}
