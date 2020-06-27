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

            string[] nomes;
             

            switch (cbListar.SelectedIndex)
            {
                case 0:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));

                        nomes = lista.ListarTeste().Split('%');
                       
                        for(int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 1:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Mamifero));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 2:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IOviparo));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 3:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IAquatico));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 4:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IVoar));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 5:
                    {

                        lista = Arvore.GetListaPorIdade();
                        lbListar.Items.Clear();

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 6:
                    {
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));
                        lbListar.Items.Clear();

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                case 7:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(IPredador));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
                    }
                    break;
                default:
                    {
                        lbListar.Items.Clear();
                        lista = Arvore.GetAllTiposAnimais(typeof(Animal));

                        nomes = lista.ListarTeste().Split('%');

                        for (int x = 0; x < lista.qtde; x++)
                        {
                            lbListar.Items.Add(nomes[x]);
                        }
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

            Leao Le = new Leao();
            Le.Cor_pelos = "laranja";
            Le.Data_Nascimento = Convert.ToDateTime("29/01/2010");
            Le.QtMamas = 2;
            Le.Nome = "Simba";
            Le.Sexo = 'M';

            Arvore.Insere(Le);

            Morcego mor = new Morcego();
            mor.Data_Nascimento = new DateTime(2019, 4, 21);
            mor.Nome = "Noibat";
            mor.Sexo = 'M';
            mor.Cor_pelos = "Preta";
            mor.QtMamas = 3;

            Arvore.Insere(mor);

            Ornitorrinco orn = new Ornitorrinco();
            orn.Cor_pelos = "verde água";
            orn.Data_Nascimento = new DateTime(2020, 6, 17);
            orn.Nome = "Perry";
            orn.QtMamas = 6;
            orn.Sexo = 'M';

            Arvore.Insere(orn);

            Pato pa = new Pato();
            pa.Cor_penas = "branco";
            pa.Data_Nascimento = new DateTime(2018, 8, 12);
            pa.Nome = "Mist";
            pa.Sexo = 'F';

            Arvore.Insere(pa);

            Pinguim pin = new Pinguim();
            pin.Cor_penas = "preta";
            pin.Data_Nascimento = new DateTime(2015, 4, 4);
            pin.Nome = "piplup";
            pin.Sexo = 'M';

            Arvore.Insere(pin);

            Pombo pom = new Pombo();
            pom.Cor_penas = "cinza";
            pom.Data_Nascimento = new DateTime(2011, 3, 1);
            pom.Nome = "pidove";
            pom.Sexo = 'M';

            Arvore.Insere(pom);

            Tartaruga tar = new Tartaruga();
            tar.Data_Nascimento = new DateTime(1980, 11, 20);
            tar.Nome = "Wuo";
            tar.Sexo = 'M';

            Arvore.Insere(tar);

            Tigre tig = new Tigre();
            tig.Cor_pelos = "laranja";
            tig.Data_Nascimento = new DateTime(2000, 2, 20);
            tig.QtMamas = 6;
            tig.Nome = "Bonde Do Tigrão";
            tig.Sexo = 'M';

            Arvore.Insere(tig);
        }




        private void LbListar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int i = lbListar.SelectedIndex;
                string nome = lbListar.Items[i].ToString();
                string[] nomes = nome.Split('\n');
                nome = nomes[1].Substring(nome.IndexOf(' '));
                nome = nome.Replace("\r", "").Trim();
                lbListar.SelectedItem = null;
                PassarDados.nome = nome;
            }
            catch
            {
                return;
            }

        }
    }
}
