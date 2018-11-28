using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokoMarsicTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime novaGodina = new DateTime(DateTime.Now.Year + 1, 1, 1);
            TimeSpan preostalo = novaGodina - DateTime.Now;
            Console.WriteLine("Do Nove godine preostalo je:");
            Console.WriteLine("{0} ana, {1} ati, {2} minuta , {3} sekundi", preostalo.Days, preostalo.Hours, preostalo.Minutes, preostalo.Seconds);
            Console.WriteLine("U danima: {0}", preostalo.TotalDays);
            Console.WriteLine("U satima: {0}", preostalo.TotalHours);
            Console.WriteLine("U min.: { 0}", preostalo.TotalMinutes);
            Console.WriteLine("U sek.: { 0}", preostalo.TotalSeconds);
            Console.ReadKey();
        }
    }
}
