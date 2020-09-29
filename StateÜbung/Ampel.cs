using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
    public class Ampel
    {
        public IState Current { get; set; }
        public  IState Red { get; }
        public IState Green { get; }
        public IState Off { get; }

        public Ampel()
        {
            Red = new RedState(this);
            Green = new GreenState(this);
            Off = new OffState(this);
            Current = Off;
        }

        public virtual void NextColor()
        {
            Current.NextColor();
        }
        public virtual string GetColor()
        {
            return Current.GetColor();
        }
        public virtual void SwitchOn()
        {
            Current.SwitchOn();
        }

        public virtual void SwitchOff()
        {
            Current.SwitchOff();
         }
    }
}
