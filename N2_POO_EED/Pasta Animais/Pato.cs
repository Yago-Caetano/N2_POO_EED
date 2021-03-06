﻿using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Interfaces_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace N2_POO_EED.Animais
{
    class Pato : Ave,IVoar,IAquatico,IOviparo
    {
        private int altitudeMaxima=6400;
        private double velocidadeVoo=52.0;
        private bool viveTerra = true;
        private bool mergulho = true;
        private bool aguaDoce = true;

        public override string ToString()
        {
            return "Tipo: Pato" + Environment.NewLine + base.ToString() + $"Altitude Máxima: {altitudeMaxima}"
                + Environment.NewLine + $"Velocidade De Voo: {velocidadeVoo}km/h" + Environment.NewLine +
                "Vive Em Terra? Sim" + Environment.NewLine + "Mergulha? Sim" + Environment.NewLine +
                 "Vive na água doce? Sim" + Environment.NewLine; ;
        }

        public override string Ciscar()
        {
            return "duck\\actions\\scratch\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Movimentar()
        {
            return "duck\\actions\\walk\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Comunicar()
        {
            return "duck\\actions\\communicate\\video.3gp";
            //throw new NotImplementedException();
        }

        public override string Alimentar()
        {
            return "duck\\actions\\feed\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Voar()
        {
            return "duck\\actions\\fly\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Botar()
        {
            return "duck\\actions\\lay_egg\\video.3gp";
            //throw new NotImplementedException();
        }

        public string Chocar()
        {
            return "duck\\actions\\hatch_the_egg\\video.3gp";
            //throw new NotImplementedException();
        }

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


    }
}
