using N2_POO_EED.Interfaces_Animais;
using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace N2_POO_EED.Pasta_Animais
{
    class Cachorro : Mamifero, IPredador
    {
        public override string ToString()
        {
          return "Tipo: Cachorro" + Environment.NewLine + base.ToString();
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

        public string Ataque()
        {
            throw new NotImplementedException();
        }

        public Cachorro(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor):base(_nome, _data, _sexo, _qtMamas, cor)
        {
            carnivoro = true;
            peconhento = false;
            pelos = true;
        }
        public Cachorro()
        {
            pelos = true;
            carnivoro = true;
            peconhento = false;
        }

    }
}
