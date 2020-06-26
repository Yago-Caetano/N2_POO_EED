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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

        Lista list;

        private void cboxAnimaisCadastrados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void btnNomeAnimal_Click(object sender, RoutedEventArgs e)
        {
           
            NodoLista aux = new NodoLista();
            try
            {
                aux = list.Find(txtNome.Text);
                if (aux == null)
                    MessageBox.Show("O nome não foi encontrado!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                lbAnimais.Items.Add(aux);
                txtNome.Clear();
            }
            catch
            {
                MessageBox.Show("Nenhum animal foi cadastrado!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
