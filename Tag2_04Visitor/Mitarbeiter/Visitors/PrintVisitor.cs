using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public class PrintVisitor : AbstractBaseMitarbeiterVisitor
    {
        public override void Visit(Gehaltsempfaenger gehaltsempfaenger)
        {
            Console.WriteLine(gehaltsempfaenger);
        }

        public override void Visit(Lohnempfaenger lohnempfaenger)
        {
            Console.WriteLine(lohnempfaenger);
        }
    }
}
