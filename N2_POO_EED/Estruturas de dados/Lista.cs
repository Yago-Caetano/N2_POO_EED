using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N2_POO_EED.Interfaces_Animais;
using N2_POO_EED.Classes_ancestrais_Animais;


namespace N2_POO_EED.Estruturas_de_dados
{
    class Lista : IEnumerable, IEnumerator
    {
        NodoLista primeiro = null; // ponteiro para o primeiro elemento da lista    
        NodoLista ultimo = null;
        public int qtde = 0;
        private NodoLista atual = null;

        public object Current
        {
            get
            {
                if (atual == null)
                    return null;
                else
                    return atual.Dado;
            }
        }

        /// <summary>
        /// Método para inserir um valor na lista
        /// </summary>
        /// <param name="anterior">o nodo que será o anterior ao nodo inserido.
        /// Se o novo nodo for o primeiro, passe null</param>
        /// <param name="valor">o valor a ser inserido</param>
        private void InserirNaPosicao(NodoLista anterior, Animal valor)
        {
            NodoLista novo = new NodoLista();
            novo.Dado = valor;

            if (anterior == null)
            {
                if (qtde == 0)
                {
                    primeiro = novo;
                    ultimo = novo;
                }

                else
                {
                    novo.Proximo = primeiro;
                    primeiro.Anterior = novo;
                    primeiro = novo;
                }
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                novo.Anterior = anterior;
                anterior.Proximo = novo;
                if (novo.Proximo == null)
                    ultimo = novo;
                else
                    novo.Proximo.Anterior = novo;

            }
            qtde++;
        }

        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Animal valor)
        {
            InserirNaPosicao(null, valor);
        }


        /// <summary>
        /// Insere um valor no final da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(Animal valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                NodoLista aux = new NodoLista();
                aux.Dado = valor;
                aux.Anterior = ultimo;
                ultimo.Proximo = aux;
                ultimo = aux;
                qtde++;
                /*Nodo aux = primeiro;
                 * while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);*/
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Animal valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");

            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }

        /// <summary>
        /// Remove um elemento da lista com base em sua posição, que inicia
        /// do zero
        /// </summary>
        /// <param name="posicao">posição</param>
        public void RemoverDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");

            if (posicao == 0)
                primeiro = primeiro.Proximo;
            else
            {
                //descobre qual é o nodo anterior que será excluido
                NodoLista aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                aux.Proximo = aux.Proximo.Proximo;
                if (aux.Proximo == null)
                    ultimo = aux;
                else
                    aux.Proximo.Anterior = aux;
            }

            qtde--;
        }
        /// <summary>
        /// Coloca o animal na lista em posição de acordo com a idade.
        /// </summary>
        /// <param name="animal">animal a ser inserido na lista</param>
        public void AdicionarEmOrdem(Animal animal)
        {
            NodoLista aux = primeiro;
            int posicao = 0;
            if (qtde == 0)
                InserirNoInicio(animal);
            else
            {
                while (aux != null)
                {
                    if (aux.Dado.Idade() > animal.Idade())
                    {
                        if (posicao == 0)
                            InserirNoInicio(animal);
                        else
                            InserirNaPosicao(animal, posicao);

                        return;
                    }
                    aux = aux.Proximo;
                    posicao++;
                }
                InserirNoFim(animal);
            }

        }

        /// <summary>
        /// Retorna um string com todos os elementos da lista concatenados
        /// </summary>
        /// <returns></returns>
        public string Listar()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                r = r + Environment.NewLine + aux.Dado.ToString();
                aux = aux.Proximo;
            }
            return r.Trim();
        }
        /// <summary>
        /// Retorna um string com todos os elementos da lista concatenados
        /// </summary>
        /// <returns></returns>
        public string ListarTeste()
        {
            string r = string.Empty;
            NodoLista aux = primeiro;
            while (aux != null)
            {
                r = r  + aux.Dado.ToString() + "%";
                aux = aux.Proximo;
            }
            return r.Trim();
        }

        /// <summary>
        /// Procura na lista e retorna um nodo baseado no parametro (nome) , caso não eo encontre retorna null
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public NodoLista Find(string nome)
        {
          
            NodoLista aux = primeiro;
            while (aux != null)
            {
                if (aux.Dado.Nome.ToUpper() == nome.ToUpper())
                    break;
                else
                    aux = aux.Proximo;
            }
            return aux;
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public bool MoveNext()
        {
            if (qtde == 0)
                return false;
            else if (atual == null)
            {
                atual = primeiro;
                return true;
            }
            else
            {
                atual = atual.Proximo;
                return (atual != null);
            }


        }

        public void Reset()
        {
            atual = null;
        }

    }
}
