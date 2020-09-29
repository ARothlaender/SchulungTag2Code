using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
   public class GreenState: AbstractColorState
    {
        public GreenState(Ampel ampel) : base(ampel)
        {
        }

        public override string GetColor()
        {
            return "green";
        }

    
        public override void NextColor()
        {
            Ampel.Current = Ampel.Red;
        }

       
    }
}
