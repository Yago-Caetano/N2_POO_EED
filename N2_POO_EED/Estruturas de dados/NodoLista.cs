using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Estruturas_de_dados
{
    class NodoLista
    {
        public Object Dado { get; set; }
        public NodoLista Proximo { get; set; }

        public NodoLista Anterior { get; set; }

        /// <summary>
        /// construtor sem parâmetros
        /// </summary>
        public NodoLista()
        {
            Dado = null;
            Proximo = null;
        }

    }
}
