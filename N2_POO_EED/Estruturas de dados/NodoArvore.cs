using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Estruturas_de_dados
{
    class NodoArvore
    {
        private NodoArvore no_pai = null;
        private NodoArvore no_direita = null;
        private NodoArvore no_esquerda = null;
    
        private Animal animal = null;

        public Animal GetValor() { return animal; }

        public void SetValor(Animal value) { animal = value; }

        public void SetNoPai(NodoArvore no) { no_pai = no; }

        public void SetNoDireita(NodoArvore no) { no_direita = no; }

        public void SetNoEsquerda(NodoArvore no) { no_esquerda = no; }

        public NodoArvore GetNoPai() { return no_pai; }

        public NodoArvore GetNoDireita() { return no_direita; }

        public NodoArvore GetNoEsquerda() { return no_esquerda; }

        public Boolean NoEhRaiz(NodoArvore no) { return no.GetNoPai() == null; }

        /// <summary>
        /// Verifica se o nodo é externo (ponta da arvore sem nenhum filho
        /// </summary>
        /// <returns></returns>
        public bool EhExterno()
        {
            return (no_direita == null) && (no_esquerda == null);
        }
        /// <summary>
        /// Verifica se o nodo é interno, tem pelo menos 1 filho
        /// </summary>
        /// <returns></returns>
        public bool EhInterno()
        {
            return (no_direita != null) || (no_esquerda != null);
        }

        /// <summary>
        /// Cria um no externo, sem filhos
        /// </summary>
        /// <param name="noPai"></param>
        /// <returns></returns>
        public static NodoArvore CriaNoExterno(NodoArvore noPai)
        {
            NodoArvore no = new NodoArvore();
            no.SetNoPai(noPai);
            return no;
        }



    }
}
