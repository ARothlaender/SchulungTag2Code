using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
    public abstract class AbstractState : IState
    {
        public Ampel Ampel { get; }
        public AbstractState(Ampel ampel)
        {
            Ampel = ampel;
        }
        public virtual string GetColor()
        {
            throw new NotSupportedException();
        }

        public virtual void NextColor()
        {
            throw new NotSupportedException();
        }

        public virtual void SwitchOn()
        {
            throw new NotImplementedException();
        }

        public virtual void SwitchOff()
        {
            throw new NotImplementedException();
        }
    }
}
