using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public abstract class AbstractBaseMitarbeiterVisitor : MitarbeiterVisitor
    {
        public virtual void finish()
        {
           
        }

        public virtual void start()
        {
            
        }


        public abstract void Visit(Gehaltsempfaenger gehaltsempfaenger);


        public abstract void Visit(Lohnempfaenger lohnempfaenger);

       
        
    }
}
