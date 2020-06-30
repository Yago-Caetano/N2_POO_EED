using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Interfaces_Animais;

namespace N2_POO_EED.Pasta_Animais
{
    class Gato : Mamifero, IPredador
    {
        public override string ToString()
        {
            return "Tipo: Gato" + Environment.NewLine + base.ToString();
        }

        public string Ataque()
        {
            throw new NotImplementedException();
        }

        public override string Amamentar()
        {
            throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            throw new NotImplementedException();
        }

        public Gato(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor) : base(_nome, _data, _sexo, _qtMamas, cor)
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }
        public Gato()
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }

    }
}
