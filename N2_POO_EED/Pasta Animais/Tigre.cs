using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Tigre : Mamifero, IPredador
    {
        public override string ToString()
        {
            return "Tipo: Tigre" + Environment.NewLine + base.ToString();
        }

        public override string Amamentar()
        {
            return "tiger\\actions\\breastfeed\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "tiger\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "tiger\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "tiger\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "tiger\\actions\\attack\\video.3gp";
            //throw new NotImplementedException();
        }

        public Tigre(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor) : base(_nome, _data, _sexo, _qtMamas, cor)
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }
        public Tigre()
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }

    }
}
