using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioDevices;
using AudioDevices1;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadKey();

            //maak een track aan
            Track t1 = new Track(1, "test 1");
            // maak een time aan
            Time time1 = new Time(400);
            // voeg de tijd toe aan de track
            t1.Length = time1;
            //stel de style in
            t1.Type = Category.HipHop;
            // voeg nog 3 tracks toe met hulp van verschillende constructors
            Track t2 = new Track(2, "green");
            Track t3 = new Track(3, "yellow");
            Track t4 = new Track(4, "Draait om", "Boef");
            //dia 30 tot hier
            Console.ReadLine();

        }
    }
}
