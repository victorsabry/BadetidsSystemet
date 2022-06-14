using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadetidsSystemet
{
    class BadetidsPeriode
    {
        //Jeg har valgt at lave auto properties da det er nemmere og ser pænere ud
       public string Type { get; private set; }
        public DayOfWeek UgeDag { get; private set; }
        public DateTime StartTidspukt { get; private set; }
        public DateTime SlutTidspukt { get; private set; }        
        public Dictionary<string, Kreds> Kredse { get; }

        public BadetidsPeriode(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt)
        {
            if (startTidspunkt >= slutTidspunkt)
            {
                throw new ArgumentException("Start tidspunket kan ikke være senere end slut tidspunktet");
            }

            if (type.Length < 4)
            {
                throw new ArgumentException("Type skal indeholde minimum 4 tegn");
            }

            Type = type;
            UgeDag = ugeDag;
            StartTidspukt = startTidspunkt;
            SlutTidspukt = slutTidspunkt;

            Kredse = new Dictionary<string, Kreds>();
        }

        public virtual void AdderKreds(Kreds kreds)
        {
            Kredse.Add(kreds.ID, kreds);
        }

        public virtual void SletterKreds(string id)
        {
            Kredse.Remove(id);
        }

        private string BadetidsLinjer()
        {
            string result = $"{Type} ({UgeDag}) fra klokken: {StartTidspukt.TimeOfDay} til {SlutTidspukt.TimeOfDay}\n";

            for (int i = 0; i < Kredse.Values.Count; i++)
            {
                var kreds = Kredse.ElementAt(i).Value;
                result += kreds + "\n";
            }
            return result;
        }   

        public override string ToString()
        {
            return BadetidsLinjer();
        }
    }
}
