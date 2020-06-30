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

      /*  private void BtnList_Click(object sender, RoutedEventArgs e)
        {
            animalList Tela = new animalList();
            Tela.Show();
        }*/

       /* private void Btn_telaCadastro_Click(object sender, RoutedEventArgs e)
        {
            create telaCadastro = new create();
            telaCadastro.Show();
        }*/

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            create telaCadastro = new create();
            telaCadastro.Show();
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            animalList list = new animalList();
            list.Show();
        }


        private void ImSel_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1,1);
            imSel.RenderTransform = scaleTransform1;
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1,1.1);
            imSel.RenderTransform = scaleTransform1;
        }

        private void ImCriar_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            imCriar.RenderTransform = scaleTransform1;
        }

        private void ImCriar_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            imCriar.RenderTransform = scaleTransform1;
        }
        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
         

            about telaSObre = new about();
            telaSObre.Show();
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            imSobre.RenderTransform = scaleTransform1;
        }

        private void ImSobre_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            imSobre.RenderTransform = scaleTransform1;
        }
    }
}
