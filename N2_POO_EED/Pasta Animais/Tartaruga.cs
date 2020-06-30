using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Tartaruga : Reptil,IOviparo
    {
        public override string ToString()
        {
            return "Tipo: Tartaruga" + Environment.NewLine + base.ToString();
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

        public string Botar()
        {
            throw new NotImplementedException();
        }

        public string Chocar()
        {
            throw new NotImplementedException();
        }

        public Tartaruga(string _nome, DateTime _data, char _sexo) : base(_nome, _data, _sexo)
        {
            escamas = true;
            carnivoro = false;
            peconhento = false;
            casco = true;
        }
        public Tartaruga()
        {
            escamas = true;
            carnivoro = false;
            peconhento = false;
            casco = true;
        }

        public bool ViveEmTerra => throw new NotImplementedException();

        public bool Mergulho => throw new NotImplementedException();

        public bool AguaDoce => throw new NotImplementedException();


    }
}
