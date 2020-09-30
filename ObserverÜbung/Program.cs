using System;
using Tiere;

namespace DYEProjekt
{
    class Program
    {

        Metzger metzger = new Metzger();
        Spediteur spediteur = new Spediteur();
        static void Main(string[] args)
        {
            new Program().run();
        }

        private void run()
        {
            Schwein piggy = new Schwein("Miss Piggy");
        
            piggy.PigTooFatEvent += spediteur.fahren;
            piggy.PigTooFatEvent += Piggy_PigTooFatEvent;
            piggy.PropertyChangedEvent += Piggy_PropertyChangedEvent;

           

            for (int i = 0; i < 10; i++)
            {
                piggy.Fressen();
            }

           
        }

        private void Piggy_PropertyChangedEvent(object sender, Common.PropertyChangedEventArgs e)
        {
            //unsauber
            Console.WriteLine(e); 
        }

        private void Piggy_AnyEvent(object sender, EventArgs e)
        {
            spediteur.fahren(sender);
        }

        private void Piggy_PigTooFatEvent(Schwein schwein)
        {
            metzger.schlachten();
        }
    }
   

    class Metzger 
    {
        public void schlachten()
        {
            Console.WriteLine("Messer wetz");
        }
    }

    class Spediteur
    {
        public void fahren(Object ware)
        {
            Console.WriteLine("Wir fahren auf der Autobahn");
        }
    }
}
