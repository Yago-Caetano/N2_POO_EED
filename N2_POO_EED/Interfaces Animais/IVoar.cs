using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Interfaces_Animais
{
    interface IVoar
    {
        string Voar();
        int AltitudeMaximaMetros { get;}

        double VelocidadeVoo { get;} //em km/h
    }
}
