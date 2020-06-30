using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Coruja : Ave, IVoar,IPredador,IOviparo
    {
        private int altitudeMaxima = 1000;
        private double velocidadeVoo = 15.0;

        public override string ToString()
        {
            return "Tipo: Coruja" + Environment.NewLine + base.ToString() + $"Altitude Máxima: {altitudeMaxima}"
                + Environment.NewLine + $"Velocidade De Voo: {velocidadeVoo}km/h" + Environment.NewLine;
        }

        public override string Ciscar()
        {
            return "owl\\actions\\scratch\\video.3gp"; 
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "owl\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "owl\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "owl\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Voar()
        {
            return "owl\\actions\\fly\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "owl\\actions\\attack\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Botar()
        {
            return "owl\\actions\\lay_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Chocar()
        {
            return "owl\\actions\\hatch_the_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public Coruja()
        {
            carnivoro = true;
            peconhento = false;
            rapina = true;
        }
        public Coruja(string _nome, DateTime _data, char _sexo, string _cor) : base(_nome, _data, _sexo, _cor)
        {
            carnivoro = true;
            peconhento = false;
            rapina = true;
        }
        public int AltitudeMaximaMetros
        {
            get { return altitudeMaxima; }
        }
        public double VelocidadeVoo
        {
            get { return velocidadeVoo; }
        }


    }
}
