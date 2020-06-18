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

namespace N2_POO_EED
{
    /// <summary>
    /// Lógica interna para animalList.xaml
    /// </summary>
    public partial class animalList : Window
    {

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
            Lista lista;
            if(Arvore.QtdeNodosInternos() == 0)
            {
                MessageBox.Show("Cadastre um animal antes de listar!!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            switch (cbListar.SelectedIndex)
            {
                case 0:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                case 1:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(Mamifero));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                case 2:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(IOviparo));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                case 3:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(IAquatico));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                case 4:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(IVoar));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                case 5:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetListaPorIdade();
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
                default:
                    {
                        txtListar.Text = "";
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));
                        txtListar.Text += lista.Listar() + Environment.NewLine + Environment.NewLine;
                    }
                    break;
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Baleia ba = new Baleia();
            ba.Cor_pelos = "Azul";
            ba.Data_Nascimento = Convert.ToDateTime("23/03/2001");
            ba.Nome = "Oliver";
            ba.QtMamas = 5;
            ba.Sexo = 'M';

            Arvore.Insere(ba);
        }


        private void BtnCachorro_Click(object sender, RoutedEventArgs e)
        {
            Cachorro Ca = new Cachorro();
            Ca.Cor_pelos = "Marrom";
            Ca.Data_Nascimento = Convert.ToDateTime("23/03/2001");
            Ca.QtMamas = 6;
            Ca.Nome = "Cátia";
            Ca.Sexo = 'F';

            Arvore.Insere(Ca);
        }

        private void BtnCriarCobra_Click(object sender, RoutedEventArgs e)
        {
            Cobra Co = new Cobra();
            Co.Data_Nascimento = Convert.ToDateTime("25/08/1999");
            Co.Nome = "Sérgio";
            Co.Sexo = 'M';

            Arvore.Insere(Co);
        }

        private void BtnCriarTodos_Click(object sender, RoutedEventArgs e)
        {
            Baleia ba = new Baleia();
            ba.Cor_pelos = "Azul";
            ba.Data_Nascimento = Convert.ToDateTime("23/03/2001");
            ba.Nome = "Oliver";
            ba.QtMamas = 5;
            ba.Sexo = 'M';

            Arvore.Insere(ba);

            Cachorro Ca = new Cachorro();
            Ca.Cor_pelos = "Marrom";
            Ca.Data_Nascimento = Convert.ToDateTime("23/03/2001");
            Ca.QtMamas = 6;
            Ca.Nome = "Cátia";
            Ca.Sexo = 'F';

            Arvore.Insere(Ca);

            Cobra Co = new Cobra();
            Co.Data_Nascimento = Convert.ToDateTime("25/08/1999");
            Co.Nome = "Sérgio";
            Co.Sexo = 'M';

            Arvore.Insere(Co);

            Coruja coru = new Coruja();
            coru.Data_Nascimento = new DateTime(2014, 4, 21);
            coru.Nome = "Kuro";
            coru.Sexo = 'F';
            coru.Cor_penas = "Preta";           

            Arvore.Insere(coru);

            Gato Ga = new Gato();
            Ga.Cor_pelos = "cinza";
            Ga.Data_Nascimento = Convert.ToDateTime("12/08/2007");
            Ga.QtMamas = 6;
            Ga.Nome = "Miss";
            Ga.Sexo = 'F';

            Arvore.Insere(Ga);

            Gaviao Gav = new Gaviao();
            Gav.Data_Nascimento = new DateTime(2000, 7, 2);
            Gav.Nome = "Pedrito";
            Gav.Sexo = 'M';
            Gav.Cor_penas = "Cinza";

            Arvore.Insere(Gav);
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
