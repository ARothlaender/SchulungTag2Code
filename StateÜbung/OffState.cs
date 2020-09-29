using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
    public class OffState : AbstractState
    {
        public OffState(Ampel ampel) : base(ampel)
        {
        }

        public override void SwitchOn()
        {
            Ampel.Current = Ampel.Red;
        }
    }
}
