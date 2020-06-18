﻿using System;
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

             if (cbListar.SelectedIndex == 0)
             {
                 lista = Arvore.GetAllTiposAnimais(typeof(Animal));

                
                 txtListar.AppendText(lista.Listar());
             }
        }

    }
}
