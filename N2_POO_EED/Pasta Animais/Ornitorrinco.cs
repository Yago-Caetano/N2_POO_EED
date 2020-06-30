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

        public override string ToString()
        {
            return "Tipo: Ornitorrinco" + Environment.NewLine + base.ToString() + $"Vive Em Terra? Sim" + Environment.NewLine +
                $"Mergulha? Sim" + Environment.NewLine +
                 $"Vive na água doce? Sim" + Environment.NewLine;
        }

        public override string Amamentar()
        {
            return "platypus\\actions\\breastfeed\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "platypus\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "platypus\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "platypus\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Botar()
        {
            return "platypus\\actions\\lay_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Chocar()
        {
            return "platypus\\actions\\hatch_the_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public Ornitorrinco(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor)
        {
            Nome = _nome;
            Data_Nascimento = _data;
            this.Sexo = _sexo;
            qtMamas = 0; //apesar de ser mamifero o ornitorrinco não tem mamas, mas ele dá leite pela barriga
            Cor_pelos = cor;
            carnivoro = true;
            peconhento = true;
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


    }
}
