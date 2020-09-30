using Common;
using DYEProjekt;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tiere
{
    public class Schwein
    {
        public delegate void SchweinHandler(Schwein schwein);

       
        
        public event SchweinHandler PigTooFatEvent;
        public event EventHandler<PropertyChangedEventArgs> PropertyChangedEvent;
        private String name;
        public string Name
        {
            get => name;
            set
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", Name, value);
                name = value;
                PropertyChangedEvent?.Invoke(this,args);
            }
        }

        private int gewicht;
        public int Gewicht
        {
            get => gewicht;
            set {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs("Gewicht", Gewicht, gewicht = value);
                if (gewicht >= 20) PigTooFatEvent?.Invoke(this);
                PropertyChangedEvent?.Invoke(this, args);
            }
        }

        public Schwein() : this("Nobody")
        {
        }

        public Schwein(string name)
        {
            Name = name;
            Gewicht = 10;
        }

        public void Fressen()
        {
            Gewicht++;
        }

        public override string ToString() => $"Dieses Schwein heißt {Name} und wiegt {Gewicht}.";


    }
}