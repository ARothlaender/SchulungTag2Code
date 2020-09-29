using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
    public class RedState : AbstractColorState
    {
        public RedState(Ampel ampel) : base(ampel)
        {
        }
        public override string GetColor()
        {
            return "red";
        }


        public override void NextColor()
        {
            Ampel.Current = Ampel.Green;
        }

     
    }
}
