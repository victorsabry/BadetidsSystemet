using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadetidsSystemet
{
    class BadetidsPeriodeForLoopAndList : BadetidsPeriode
    {
        public List<Kreds> _kredseList { get; }
        public BadetidsPeriodeForLoopAndList(string type, DayOfWeek ugeDag, DateTime startTidspunkt, DateTime slutTidspunkt) : 
            base(type, ugeDag, startTidspunkt, slutTidspunkt)
        {
            _kredseList = new List<Kreds>(); 
        }

        public override void AdderKreds(Kreds kreds)
        {
            _kredseList.Add(kreds);
        }

        //public override void SletterKreds(int index)
        //{
        //    _kredseList.RemoveAt(index);
        //}

        public override string ToString()
        {
            return $"";
        }
    }
}
