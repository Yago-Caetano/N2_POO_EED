using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Classes_ancestrais_Animais;


namespace N2_POO_EED.Pasta_Animais
{
    class Ornitorrinco : Mamifero,IOviparo,IAquatico
    {
        private bool viveTerra = true;
        private bool mergulho = true;
        private bool aguaDoce = true;

        public Ornitorrinco(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor)
        {
            Nome = _nome;
            Data_Nascimento = _data;
            this.Sexo = _sexo;
            QtMamas = _qtMamas;
            Cor_pelos = cor;
            carnivoro = false;
            peconhento = false;
            pelos = true;
        }
        public Ornitorrinco()
        {
            carnivoro = false;
            peconhento = false;
            pelos = true;
        }


        public bool ViveEmTerra
        {
            get { return viveTerra; }
        }
        public bool Mergulho
        {
            get { return mergulho; }
        }
        public bool AguaDoce
        {
            get { return aguaDoce; }
        }

        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public override void Amamentar()
        {
            throw new NotImplementedException();
        }

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
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
