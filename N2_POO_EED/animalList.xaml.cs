using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using N2_POO_EED.Estruturas_de_dados;
using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Pasta_Animais;
using N2_POO_EED.Interfaces_Animais;
using N2_POO_EED.Animais;


namespace N2_POO_EED
{
    /// <summary>
    /// Lógica interna para animalList.xaml
    /// </summary>
    public partial class animalList : Window
    {
        
        Lista lista;
        public animalList()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            animalList TelaListar = new animalList();
            TelaListar.Show();
        }

        private void CbListar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Arvore.QtdeNodosInternos() == 0)
            {
                MessageBox.Show("Cadastre um animal antes de listar!!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            switch (cbListar.SelectedIndex)
            {
                case 0:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));

                        ListarDados();
                    }
                    break;
                case 1:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Mamifero));

                        ListarDados();
                    }
                    break;
                case 2:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IOviparo));
                        ListarDados();
                    }
                    break;
                case 3:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IAquatico));
                        ListarDados();
                    }
                    break;
                case 4:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IVoar));
                        ListarDados();
                    }
                    break;
                case 5:
                    {

                        lista = Arvore.GetListaPorIdade();
                        lbListar.Items.Clear();
                        ListarDados();
                    }
                    break;
                case 6:
                    {
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));
                        lbListar.Items.Clear();
                        ListarDados();
                    }
                    break;
                case 7:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IPredador));
                        ListarDados();
                    }
                    break;
                default:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));
                        ListarDados();
                    }
                    break;

            }

        }
        /// <summary>
        /// Insere dados no listbox
        /// </summary>
        public void ListarDados()
        {
            string[] animais;
            string[] campos;
            animais = lista.ListarNomes().Split('%');

            for (int x = 0; x < lista.qtde; x++)
            {
                campos = animais[x].Replace("\r","").Split('\n');
                lbListar.Items.Add(campos[1] + " - " + campos[0] + " - " + campos[2]);
            }
        }


        private void LbListar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*try
            {
                int i = lbListar.SelectedIndex;
                string nome = lbListar.Items[i].ToString();
                string[] nomes = nome.Split('\n');
                nome = nomes[1].Substring(nome.IndexOf(' '));
                nome = nome.Replace("\r", "").Trim();
                lbListar.SelectedItem = null;



                if (MessageBox.Show($"Tem certeza que quer usar as ações do animal {nome} ?", "Confirmação", MessageBoxButton.YesNo,MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    //PassarDados.nome = nome;
                    animalActions novaTela = new animalActions(nome);
                    novaTela.Show();
                    this.Close();
                }
                else
                {
                    return;
                }
            /*}
            catch
            {
                return;
            }*/
        }

        private void LbListar_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
          try
          {
            int i = lbListar.SelectedIndex;
            if(i<0)
            {
               return;
            }
            string nome = lbListar.Items[i].ToString();
            string[] nomes = nome.Split('-');
            nome = nomes[0].Substring(nome.IndexOf(' '));
            nome = nome.Replace("\r", "").Trim();
            lbListar.SelectedItem = null;



            if (MessageBox.Show($"Tem certeza que quer usar as ações do animal {nome} ?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //PassarDados.nome = nome;
                animalActions novaTela = new animalActions(nome);
                novaTela.Show();
                this.Close();
            }
            else
            {
                return;
            }
            }
            catch
            {
                return;
            }
        }
    }
}
