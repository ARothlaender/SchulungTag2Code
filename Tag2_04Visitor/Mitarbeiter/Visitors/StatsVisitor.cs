using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public class StatsVisitor : MitarbeiterVisitor
    {
        private int anzahlGehaltsempfänger;
        private int anzahlLohnempfänger;
        public StatsVisitor()
        {
            this.start();
        }
        public void Visit(Gehaltsempfaenger gehaltsempfaenger)
        {
            anzahlGehaltsempfänger += 1;
        }

        public  void Visit(Lohnempfaenger lohnempfaenger)
        {
            anzahlLohnempfänger += 1;
        }
        public  void finish()
        {
            Console.WriteLine(this);
        }
        public void start()
        {
            anzahlGehaltsempfänger = 0;
            anzahlLohnempfänger = 0;
        }
        public override string ToString()
        {
            return $"Die Anzahl der Gehaltsempfänger ist : {anzahlGehaltsempfänger}.\n" +
                $"Die Anzahl der Lohnempfänger ist : {anzahlLohnempfänger}.\n" +
                $"Die Anzahl aller Mitarbeiter ist : {anzahlLohnempfänger + anzahlGehaltsempfänger}.\n";
        }
    }
}
