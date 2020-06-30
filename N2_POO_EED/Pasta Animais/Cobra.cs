using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Cobra : Reptil, IPredador,IOviparo
    {
        public override string ToString()
        {
            return "Tipo: Cobra" + Environment.NewLine + base.ToString();
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

        public string Ataque()
        {
            throw new NotImplementedException();
        }

        public Cobra(string _nome, DateTime _data, char _sexo) : base(_nome, _data, _sexo)
        {
            escamas = true;
            carnivoro = true;
            peconhento = true;
            casco = false;
        }
        public Cobra()
        {
            escamas = true;
            carnivoro = true;
            peconhento = true;
            casco = false;
        }

    }
}
