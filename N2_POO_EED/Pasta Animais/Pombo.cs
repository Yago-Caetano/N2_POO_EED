using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Pombo : Ave, IVoar
    {
        private int altitudeMaxima = 5000;
        private double velocidadeVoo = 102.0;
        public override string ToString()
        {
            return "Tipo: Pombo" + Environment.NewLine + base.ToString() + $"Altitude Máxima: {altitudeMaxima}"
                + Environment.NewLine + $"Velocidade De Voo: {velocidadeVoo}km/h" + Environment.NewLine;
        }

        public Pombo()
        {
            carnivoro = false;
            peconhento = false;
            rapina = false;
        }
        public Pombo(string _nome, DateTime _data, char _sexo, string _cor) : base(_nome, _data, _sexo, _cor)
        {
            carnivoro = false;
            peconhento = false;
            rapina = false;
        }
        public int AltitudeMaximaMetros
        {
            get { return altitudeMaxima; }
        }
        public double VelocidadeVoo
        {
            get { return velocidadeVoo; }
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

        public void Voar()
        {
            throw new NotImplementedException();
        }
    }
}
