using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Classes_ancestrais_Animais;


namespace N2_POO_EED.Pasta_Animais
{
    class Baleia : Mamifero, IAquatico
    {
        private bool viveTerra = false;
        private bool mergulho = true;
        private bool aguaDoce = false;

        
        public override string ToString()
        {
            return "Tipo: Baleia" + Environment.NewLine + base.ToString()  + $"Vive Em Terra? {(viveTerra == true ? "Sim" : "Não")}" + Environment.NewLine +
                $"Mergulha? {(mergulho == true ? "Sim" : "Não")}" + Environment.NewLine +
                 $"Vive na água doce? {(aguaDoce == true ? "Sim" : "Não")}" + Environment.NewLine;
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

        public Baleia(string _nome, DateTime _data, char _sexo, int _qtMamas) : base(_nome, _data, _sexo, _qtMamas, null)
        {
            carnivoro = true;
            pelos = false;
            peconhento = false;
        }
        public Baleia()
        {
            carnivoro = true;
            pelos = false;
            peconhento = false;
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
