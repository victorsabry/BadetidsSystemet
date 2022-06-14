using System;

namespace BadetidsSystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            var kreds1 = new Kreds("1", "Børnehold", "Køge", 17);
            var kreds2 = new Kreds("2", "Pensionister", "København", 9);
            var kreds3 = new Kreds("3", "Fritidsklub", "Greve", 19);

            var badetidsPeriode1 = new BadetidsPeriode
                ("Badning", DayOfWeek.Thursday, new DateTime().AddHours(7).AddMinutes(45), new DateTime().AddHours(9).AddMinutes(00));

            var badetidsPeriode2 = new BadetidsPeriode
                ("AftenSvaler", DayOfWeek.Friday, new DateTime().AddHours(17).AddMinutes(00), new DateTime().AddHours(18).AddMinutes(25));

            //Create method
            badetidsPeriode1.AdderKreds(kreds3);
            badetidsPeriode2.AdderKreds(kreds1);
            badetidsPeriode2.AdderKreds(kreds2);            

            Console.WriteLine($"{kreds1}");
            Console.WriteLine($"{kreds2}");
            Console.WriteLine($"{kreds3}");
            Console.WriteLine();
            Console.WriteLine(badetidsPeriode1);
            Console.WriteLine();
            Console.WriteLine(badetidsPeriode2);

            //Delete method
            badetidsPeriode2.SletterKreds("1");
            Console.WriteLine("!AFTER DELETION!");
            Console.WriteLine();
            Console.WriteLine($"{badetidsPeriode2}");
        }
    }
}
