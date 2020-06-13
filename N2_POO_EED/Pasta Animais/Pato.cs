using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N2_POO_EED.Animais
{
    class Pato : Ave, IOviparo, IVoar,IAquatico
    {
        private int altitudeMaxima=6400;
        private double velocidadeVoo=52.0;
        private bool viveTerra = true;
        private bool mergulho = true;
        private bool aguaDoce = true;

 
        public Pato()
        {
            carnivoro = false;
            peconhento = false;
            rapina = false;
        }
        public Pato(string _nome, DateTime _data, char _sexo, string _cor) : base(_nome, _data, _sexo,_cor)
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

        public void Botar()
        {
            throw new NotImplementedException();
        }

        public void Chocar()
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
