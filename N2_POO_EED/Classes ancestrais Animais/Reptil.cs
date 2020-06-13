using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Classes_ancestrais_Animais
{
    abstract class Reptil : Animal
    {
        protected bool escamas;
        protected bool casco;


        public Reptil()
        {

        }
        public Reptil(string _nome, DateTime _data, char _sexo)
           : base(_nome, _data, _sexo)
        {

        }

        public bool TemEscamas
        {
            get { return escamas; }
        }

        public bool TemCasco
        {
            get { return casco; }
        }
    }
}
