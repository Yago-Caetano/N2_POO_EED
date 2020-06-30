using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Interfaces_Animais;


namespace N2_POO_EED.Animais
{
    class Morcego : Mamifero, IVoar, IPredador
    {
        public override string ToString()
        {
            return "Tipo: Morcego" + Environment.NewLine + base.ToString() + $"Altitude Máxima: {altitudeMaxima}"
                + Environment.NewLine + $"Velocidade De Voo: {velocidadeVoo}km/h" + Environment.NewLine;
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

        public string Voar()
        {
            throw new NotImplementedException();
        }

        public string Ataque()
        {
            throw new NotImplementedException();
        }

        public Morcego(string _nome, DateTime _data, char _sexo, int _qtMamas, string cor) : base(_nome, _data, _sexo, _qtMamas, cor)
        {
            carnivoro = false;
            peconhento = false;
            pelos = true;
        }
        public Morcego()
        {
            peconhento = false;
            pelos = true;
        }


        private int altitudeMaxima=10;
        private double velocidadeVoo=160.0;

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
