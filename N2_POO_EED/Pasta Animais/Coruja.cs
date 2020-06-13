using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Pasta_Animais
{
    class Coruja : Ave, IVoar,IPredador
    {
        private int altitudeMaxima = 1000;
        private double velocidadeVoo = 15.0;
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

        public override void Alimentar()
        {
            throw new NotImplementedException();
        }

        public void Ataque()
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
