using N2_POO_EED.Classes_ancestrais_Animais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Estruturas_de_dados

{
    class Arvore
    {
        private NodoArvore raiz = null; //Raiz arvore
        private int qtdeNodosInternos = 0; // quantidade de nós internos


        public Arvore()
        {
        }
        /// <summary>
        /// Devolve a quantidade de nodos internos
        /// </summary>
        /// <returns></returns>
        public int QtdeNodosInternos()
        {
            return qtdeNodosInternos;
        }

        public NodoArvore GetRaiz() { return raiz; }

        /// <summary>
        /// Pesquisa um nodo na árvore e devolve o nodo. Caso não encontre, devolve o nodo
        /// externo onde a pesquisa parou. 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        private NodoArvore PesquisaValor(string nome, NodoArvore no)
        {
            if (no.EhExterno())
                return no; // não encontrou
            else if (no.GetValor().Nome == nome)
                return no;
            else if (nome.CompareTo(no.GetValor().Nome) >= 1)
                return PesquisaValor(nome, no.GetNoDireita());
            else
                return PesquisaValor(nome, no.GetNoEsquerda());
        }

        /// <summary>
        /// Pesquisa um valor na arvore binaria, e caso encontrado retorna ele
        /// </summary>
        /// <param name="nome">nome do animal procurado</param>
        /// <returns></returns>
        public Animal Pesquisar(string nome)
        {
            NodoArvore no_aux = new NodoArvore();
            no_aux = PesquisaValor(nome, raiz);
            if (no_aux.EhExterno())
                throw new Exception("Animal não encontrado!");
            else
                return no_aux.GetValor();
             
        }
        /// <summary>
        /// Percorre toda a arvore em sentido crescente a partir de um nodo, adicionada na lista especificada
        /// de maneira recursiva todos os itens da arvore que: são do mesmo Type que o Type especificado em
        /// tipo, ou herdam do tipo ou implementam o tipo
        /// </summary>
        /// <param name="no">Nodo que será analisado</param>
        /// <param name="list">Lista onde será armazenado os dados</param>
        /// <param name="tipo">typeof() da classe ou interface para procurar</param>
        private void PercursoInterfixado(NodoArvore no, ref Lista list, Type tipo)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixado(no.GetNoEsquerda(), ref list, tipo);          
            if (no.GetValor().GetType() == tipo || no.GetValor().GetType().IsSubclassOf(tipo) 
                || no.GetValor().GetType().GetInterfaces().Contains(tipo)) 
                list.InserirNoFim(no.GetValor());// Se for do mesmo tipo do objeto passado como parametro, ou herdar dele ou implementar ele
            PercursoInterfixado(no.GetNoDireita(),ref list, tipo);

        }
        private void PercursoInterfixadoIdade(NodoArvore no, ref Lista list)
        {
            if (no.EhExterno())
                return;
            PercursoInterfixadoIdade(no.GetNoEsquerda(), ref list);
             list.AdicionarEmOrdem(no.GetValor());// Se for do mesmo tipo do objeto passado como parametro, ou herdar dele ou implementar ele
            PercursoInterfixadoIdade(no.GetNoDireita(), ref list);

        }
        /// <summary>
        /// Devolve uma lista com todos os animais do tipo especificados no parametro animal, pode ser tanto uma classe
        /// quanto uma interface
        /// </summary>
        /// <param name="animal">typeof() da classe ou interface que deseja procurar na arvore</param>
        /// <returns>Lista com todos os dados que tem o mesmo tipo do parametro animal, ou herdam dele ou implementam ele</returns>
        public Lista GetAllTiposAnimais(Type animal)
        {
            Lista lista = new Lista();
            PercursoInterfixado(raiz, ref lista, animal);
            foreach (Animal a in lista)
            {
                Console.WriteLine(a.Nome);
            }
            return lista;
        }
        /// <summary>
        /// Retorna uma lista com todos os animais ordenados por idade de forma crescente
        /// </summary>
        /// <returns>lsita com os animais ordenados por idade </returns>
        public Lista GetListaPorIdade()
        {
            Lista lista = new Lista();
            PercursoInterfixadoIdade(raiz, ref lista);
            foreach (Animal a in lista)
            {
                Console.WriteLine(a.Nome);
            }
            return lista;
        }

        /// <summary>
        /// Insere um valor na árvore. não aceita valores repetidos, se o valor já existir ele devolve falso
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> retorna falso se o valor já existir e verdadeiro se o valor for inserido com sucesso</returns>
        public bool Insere(Animal valor) // insere um valor int
        {
            NodoArvore no_aux;
            if (qtdeNodosInternos == 0) // árvore vazia!
            {
                // árvore vazia, devemos criar o primeiro Nodo, que será a raiz
                no_aux = new NodoArvore();
                raiz = no_aux;
            }
            else
            {
                // localiza onde deve ser inserido o novo nó.
                no_aux = PesquisaValor(valor.Nome, raiz);
                if (no_aux.EhInterno())
                {
                    throw new Exception("Este animal já existe na árvore!!!!");
                }
            }
            // este era um Nodo externo e portanto não tinha filhos.
            // Agora ele passará a ser interno, portanto devemos criar outros 2
            // nodos externos (filhos) para ele.
            no_aux.SetValor(valor);
            no_aux.SetNoEsquerda(NodoArvore.CriaNoExterno(no_aux));
            no_aux.SetNoDireita(NodoArvore.CriaNoExterno(no_aux));
            qtdeNodosInternos++;
            return true;
        }

        /// <summary>
        /// Remove um valor da árvore
        /// </summary>
        /// <param name="valor"></param>
        public void Remove(string nome)
        {
            //primeiro, procuramos o nodo que tem o valor:
            NodoArvore noQueSeraApagado = PesquisaValor(nome, raiz);
            if (noQueSeraApagado == null || noQueSeraApagado.EhExterno())
                throw new Exception("Animal não existe na árvore");
            else
            {
                // um dos filhos é um nó externo
                if (noQueSeraApagado.GetNoEsquerda().EhExterno() ||
                 noQueSeraApagado.GetNoDireita().EhExterno())
                {
                    ExcluiComNodoExterno(noQueSeraApagado);
                }
                else
                {
                    ExcluiSemNodoExterno(noQueSeraApagado);
                }
            }
        }

        /// <summary>
        /// Exclui um nodo que abaixo dele possua, ao menos, 1 nodo exteno.
        /// </summary>
        /// <param name="noQueSeraApagado"></param>
        private void ExcluiComNodoExterno(NodoArvore noQueSeraApagado)
        {
            qtdeNodosInternos--;
            //descobre quem será o nodo que irá ficar no lugar do que foi apagado
            NodoArvore nodo_substituto;
            if (noQueSeraApagado.GetNoEsquerda().EhInterno())
                nodo_substituto = noQueSeraApagado.GetNoEsquerda();
            else
                nodo_substituto = noQueSeraApagado.GetNoDireita();
            // substitui o apagado pelo novo nodo
            NodoArvore PaiNodoApagado = noQueSeraApagado.GetNoPai();
            //altera o pai do novo substituto
            nodo_substituto.SetNoPai(PaiNodoApagado);
            //o pai do nodo substituto também deve ter sua referência de filho corrigida.
            //mas primeiro precisamos saber o no apagado er a raiz, que neste caso não tem pai.
            if (PaiNodoApagado != null)
            {
                if (PaiNodoApagado.GetNoDireita() == noQueSeraApagado)
                    PaiNodoApagado.SetNoDireita(nodo_substituto);
                else
                    PaiNodoApagado.SetNoEsquerda(nodo_substituto);
            }
            else
                raiz = nodo_substituto;
        }
        /// <summary>
        /// Pesquisa o próximo nodo Interno seguindo o percurso interfixado.
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        private NodoArvore PesquisaNodoInternoInterfixado(NodoArvore no)
        {
            if (no.EhExterno())
                return null;
            NodoArvore retorno = PesquisaNodoInternoInterfixado(no.GetNoEsquerda());
            if (retorno == null) 
                return no;
            else
                return retorno;
        }

        private void ExcluiSemNodoExterno(NodoArvore noQueSeraApagado)
        {
            //encontra o nodo substituto
            NodoArvore NodoSubstituto = PesquisaNodoInternoInterfixado(noQueSeraApagado.GetNoDireita());
            Console.Write("Nodo substituto: " + NodoSubstituto.GetValor().Nome);
            //Altera o valor do nodo que será removido pelo valor do nodo substituto
            noQueSeraApagado.SetValor(NodoSubstituto.GetValor());
            //Remove o nodo substituto
            ExcluiComNodoExterno(NodoSubstituto);
        }



    }
}
