using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Estruturas_de_dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace N2_POO_EED
{
    /// <summary>
    /// Lógica interna para animalActions.xaml
    /// </summary>
    public partial class animalActions : Window
    {
        public animalActions()
        {
            InitializeComponent();
        }
        Lista list = Arvore.GetListaPorIdade();

        MediaElement media;

        private void cboxAnimaisCadastrados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cboxAnimaisCadastrados.DataContext = list;
        }

        private void btnNomeAnimal_Click(object sender, RoutedEventArgs e)
        {
            NodoLista aux = new NodoLista();

            try
            {
                if (Arvore.PesquisaValor(txtNome, aux))
                {
                    //animal encontrado
                    //aux = list.Find(txtNome.Text);
                    lbAnimais.Items.Add(aux);
                }
                else
                    MessageBox.Show("O nome não foi encontrado!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch
            {
                MessageBox.Show("Cadastrar um animal primeiro!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.DefaultExt = ".";
            ofd.Filter = "Media Files (*.*)|*.*";
            ofd.ShowDialog();

            media = new MediaElement();

            try { media.Source = new Uri(ofd.FileName); }
            catch { new NullReferenceException("error"); }

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            //dispatcherTimer.Tick += new EventHandler(timer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

    }
}
