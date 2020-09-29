using System;

namespace StateÜbung
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Ampel ampel = new Ampel();
            ampel.SwitchOn();
            Console.WriteLine(ampel.GetColor());
            ampel.NextColor();
            Console.WriteLine(ampel.GetColor());
            ampel.SwitchOff();
            ampel.GetColor();
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine("Ampel ist wie erwartet aus.");

            }
            

        }
    }
}
