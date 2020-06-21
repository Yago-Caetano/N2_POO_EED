using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Pinguim : Ave, IAquatico
    {
        private bool viveTerra = true;
        private bool mergulho = true;
        private bool aguaDoce = false;

        public override string ToString()
        {
            return "Tipo: Pinguim" + Environment.NewLine + base.ToString() +  "Vive Em Terra? Sim"
                + Environment.NewLine + "Mergulha? Sim" + Environment.NewLine +
                 "Vive na água doce? Não" + Environment.NewLine; ;
        }

        public Pinguim()
        {
            carnivoro = false;
            peconhento = false;
            rapina = false;
        }
        public Pinguim(string _nome, DateTime _data, char _sexo, string _cor) : base(_nome, _data, _sexo, _cor)
        {
            carnivoro = false;
            peconhento = false;
            rapina = false;
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

        public override void Ciscar()
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
