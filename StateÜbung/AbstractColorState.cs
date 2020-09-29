using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
   public class AbstractColorState : AbstractState
    {
        public AbstractColorState(Ampel ampel) : base(ampel)
        {
        }

        public override void SwitchOff()
        {
            Ampel.Current = Ampel.Off;
        }
    }
}
