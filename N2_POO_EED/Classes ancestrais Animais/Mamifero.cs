using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Classes_ancestrais_Animais
{
    abstract class Mamifero : Animal
    {
        private int qtMamas;
        protected bool pelos;
        private string cor_pelo;


        
        public bool Pelos
        {
            get { return pelos; }
        }
        public string Cor_pelos
        {
            get { return cor_pelo; }
            set
            {
                if (value == "")
                    throw new Exception("Não é possível atribuir uma cor vazia à cor dos pelos");
                else
                    cor_pelo = value;
            }
        }
        public int QtMamas
        {
            get { return qtMamas; }
            set
            {
                if (value <=0)
                    throw new Exception("Os mamiferos tem quantidade de mamas maior que zero!");
                else
                    qtMamas = value;
            }
        }

        public Mamifero()
        {
            
        }
        public Mamifero(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor ) 
            : base( _nome,_data, _sexo)
        {
            QtMamas = _qtMamas;
            Cor_pelos = cor;
        }

        public abstract void Amamentar();

    }
}
