using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public abstract class AbstractMitarbeiterVisitor : AbstractBaseMitarbeiterVisitor
    {
       

        public override void Visit(Gehaltsempfaenger gehaltsempfaenger)
        {
            
        }

        public override  void Visit(Lohnempfaenger lohnempfaenger)
        {
            
        }
    }
}
