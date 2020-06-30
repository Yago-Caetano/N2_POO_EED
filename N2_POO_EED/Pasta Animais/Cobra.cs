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
            return "snake\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "snake\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "snake\\actions\\feed\\video.3gp";
            // throw new NotImplementedException();
        }

        public string Botar()
        {
            return "snake\\actions\\lay_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Chocar()
        {
            return "snake\\actions\\hatch_the_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "snake\\actions\\attack\\video.3gp";
            //throw new NotImplementedException();
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
