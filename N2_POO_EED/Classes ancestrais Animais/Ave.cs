using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Classes_ancestrais_Animais
{
    abstract class Ave : Animal
    {
        protected bool rapina;
        private string cor_pena;

        public override string ToString()
        {
            return base.ToString() + $"Rapina? {(rapina == true ? "Sim" : "Não")}" + Environment.NewLine + 
                $"Cor das Penas: {cor_pena}" + Environment.NewLine;
        }
        public bool Rapina
        {
            get { return rapina; }
        }
        public string Cor_penas
        {
            get { return cor_pena; }
            set
            {
                if (value == "")
                    throw new Exception("Não é possível atribuir uma cor vazia às penas da ave");
                else
                    cor_pena = value;

            }
        }

        public Ave()
        {
            
        }
        public Ave(string _nome, DateTime _data, char _sexo, string _cor)
           : base(_nome, _data, _sexo)
        {
            Cor_penas = _cor;
        }
        public abstract string Ciscar();

    }
}
