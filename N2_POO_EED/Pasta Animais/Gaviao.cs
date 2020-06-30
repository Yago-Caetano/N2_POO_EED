using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Gaviao : Ave, IVoar, IPredador,IOviparo
    {
        private int altitudeMaxima = 2000;
        private double velocidadeVoo = 320.0;

        public override string ToString()
        {
            return "Tipo: Gavião" + Environment.NewLine + base.ToString() + $"Altitude Máxima: {altitudeMaxima}"
        + Environment.NewLine + $"Velocidade De Voo: {velocidadeVoo}km/h" + Environment.NewLine;
        }

        public override string Ciscar()
        {
            return "hawk\\actions\\scratch\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "hawk\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "hawk\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "hawk\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Voar()
        {
            return "hawk\\actions\\fly\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Ataque()
        {
            return "hawk\\actions\\attack\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Botar()
        {
            return "hawk\\actions\\lay_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Chocar()
        {
            return "hawk\\actions\\hatch_the_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public Gaviao()
        {
            carnivoro = true;
            peconhento = false;
            rapina = true;
        }
        public Gaviao(string _nome, DateTime _data, char _sexo, string _cor) : base(_nome, _data, _sexo, _cor)
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
