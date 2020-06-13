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
        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Amamentar()
        {
            throw new NotImplementedException();
        }

        public void Ataque()
        {
            throw new NotImplementedException();
        }

        public override void Comunicar()
        {
            throw new NotImplementedException();
        }

        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
