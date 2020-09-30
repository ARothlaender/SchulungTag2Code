using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
   public class PropertyChangedEventArgs : EventArgs
    {
        public String PropertyName { get;}
        public Object OldValue { get; }
        public Object NewValue { get;}

        public PropertyChangedEventArgs(String propname, Object old, Object newvalue)
        {
            PropertyName = propname;
            OldValue = old;
            NewValue = newvalue;
        }
        public override string ToString() => $"Die Property {PropertyName} hat sich von {OldValue} auf {NewValue} geändert.";
    }
}
