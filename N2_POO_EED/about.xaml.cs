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
    /// Lógica interna para about.xaml
    /// </summary>
    public partial class about : Window
    {
        public about()
        {
            InitializeComponent();
        }



        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            label01.RenderTransform = scaleTransform1;
        }

        private void label01_MouseEnter_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            label01.RenderTransform = scaleTransform1;
        }

        //=================================================================================

        private void label02_MouseLeave_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            label02.RenderTransform = scaleTransform1;
        }

        private void label02_MouseEnter_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            label02.RenderTransform = scaleTransform1;
        }

        //=================================================================================

        private void label03_MouseLeave_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            label03.RenderTransform = scaleTransform1;
        }

        private void label03_MouseEnter_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            label03.RenderTransform = scaleTransform1;
        }

        //=================================================================================

        private void label04_MouseLeave_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            label04.RenderTransform = scaleTransform1;
        }

        private void label04_MouseEnter_1(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1,1.1);
            label04.RenderTransform = scaleTransform1;
        }

        //=================================================================================

        private void label05_MouseLeave(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1);
            label05.RenderTransform = scaleTransform1;
        }

        private void label05_MouseEnter(object sender, MouseEventArgs e)
        {
            ScaleTransform scaleTransform1 = new ScaleTransform(1.1, 1.1);
            label05.RenderTransform = scaleTransform1;
        }
    }
}
