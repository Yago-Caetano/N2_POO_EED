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
using System.Windows.Navigation;
using System.Windows.Shapes;
using N2_POO_EED.Pasta_Animais;
using N2_POO_EED.Estruturas_de_dados;

namespace N2_POO_EED
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Baleia ba = new Baleia();
            ba.Cor_pelos = "Azul";
            ba.Data_Nascimento =Convert.ToDateTime("23/03/2001");
            ba.Nome = "Oliver";
            ba.QtMamas = 5;
            ba.Sexo = 'M';

            Arvore.Insere(ba);

            animalList TelaListar = new animalList();
            TelaListar.Show();           
        }
    }
}
