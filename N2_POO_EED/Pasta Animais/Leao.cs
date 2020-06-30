using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Interfaces_Animais;


namespace N2_POO_EED.Pasta_Animais
{
    class Leao : Mamifero,IPredador
    {
        public override string ToString()
        {
            return "Tipo: Leão" + Environment.NewLine + base.ToString();
        }

        public override string Amamentar()
        {
            return "lion\\actions\\breastfeed\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "lion\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "lion\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "lion\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "lion\\actions\\attack\\video.3gp";
            //throw new NotImplementedException();
        }

        public Leao(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor) : base(_nome, _data, _sexo, _qtMamas, cor)
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }
        public Leao()
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }

    }
}
