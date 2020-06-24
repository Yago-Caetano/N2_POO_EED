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

        private void BtnList_Click(object sender, RoutedEventArgs e)
        {
            animalList Tela = new animalList();
            Tela.Show();
        }

        private void Btn_telaCadastro_Click(object sender, RoutedEventArgs e)
        {
            create telaCadastro = new create();
            telaCadastro.Show();
        }
    }
}
