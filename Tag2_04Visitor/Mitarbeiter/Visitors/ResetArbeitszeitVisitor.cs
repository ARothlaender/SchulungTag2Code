﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Mitarbeiter.Visitors
{
    public class ResetArbeitszeitVisitor : AbstractMitarbeiterVisitor
    {

        public override void Visit(Lohnempfaenger lohnempfaenger)
        {
            lohnempfaenger.Arbeitszeit = 0;
        }
    }
}
