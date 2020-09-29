using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public class GehaltserhöhungsVisitor : AbstractMitarbeiterVisitor
    {
       public override void Visit(Gehaltsempfaenger gehaltsempfaenger)
        {
            gehaltsempfaenger.Gehalt *= 1.03;
        }
    }
}
