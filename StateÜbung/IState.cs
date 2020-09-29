using System;
using System.Collections.Generic;
using System.Text;

namespace StateÜbung
{
    public interface IState
    {
        public string GetColor();
        public void NextColor();

        /// <summary>
        /// SwitchOn bzw. SwitchOff: Ampel komplett an/ausschalten
        /// </summary>
        public void SwitchOn();

        public void SwitchOff();

    }
}
