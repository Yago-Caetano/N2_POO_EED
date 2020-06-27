﻿using N2_POO_EED.Classes_ancestrais_Animais;
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
using N2_POO_EED.Interfaces_Animais;
using System.Reflection;
using System.IO;

namespace N2_POO_EED
{
    /// <summary>
    /// Lógica interna para animalActions.xaml
    /// </summary>
    public partial class animalActions : Window
    {
        Lista actionList;
        MediaElement media;
        Animal selectedAnimal;

        public animalActions(String nomeAnimal)
        {
            InitializeComponent();
            if(nomeAnimal != "")
            {

            }

            selectedAnimal = Arvore.Pesquisar(nomeAnimal);
            lbAnimais.Items.Add(selectedAnimal);
            actionList = new Lista();
            OrganizaAcoes();
            lbTitulo.Content = selectedAnimal.GetType().GetTypeInfo().Name + " - " + selectedAnimal.Nome;

            foreach (Object o in actionList)
            {
                cboxListaAcoes.Items.Add(o);
            }
            

        }


     


        private void OrganizaAcoes()
        {
            foreach (MethodInfo metodo in selectedAnimal.GetType().GetMethods())
            {

                if(!metodo.Name.Contains("get") && !metodo.Name.Contains("set") && !metodo.Name.Contains("Equals")
                    && !metodo.Name.Contains("ToString") && !metodo.Name.Contains("Get") && !metodo.Name.Contains("Idade"))
                {
                    actionList.InserirNoFim(metodo.Name);

                }
       
                Console.WriteLine(metodo.Name);

   
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

        private void CboxListaAcoes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            String Path = GetResourceName();
            if (Path == null)
                return;

            Console.WriteLine(Path);
            mEVideos.Source = new Uri(Path);
            mEVideos.Play();
        }


        String GetResourceName()
        {
            String Path = Directory.GetCurrentDirectory();
            Path = Path.Substring(0, Path.IndexOf("\\bin"));

            int index = cboxListaAcoes.SelectedIndex;
            if (index < 0)
                return null;

            String Action = cboxListaAcoes.Items[index].ToString();

            String AnimalName = "";

            Path += "\\assets";

            //verifica o tipo de animal selecionado
            switch (selectedAnimal.GetType().GetTypeInfo().Name)
            {
                case "Baleia":
                    AnimalName = "whale";
                    break;

                case "Cachorro":
                    AnimalName = "dog";
                    break;

                case "Cobra":
                    AnimalName = "snake";
                    break;

                case "Coruja":
                    AnimalName = "owl";
                    break;

                case "Gato":
                    AnimalName = "cat";
                    break;

                case "Gaviao":
                    AnimalName = "hawk";
                    break;

                case "Leao":
                    AnimalName = "lion";
                    break;

                case "Morcego":
                    AnimalName = "bat";
                    break;

                case "Ornitorrinco":
                    AnimalName = "platypus";
                    break;

                case "Pato":
                    AnimalName = "duck";
                    break;

                case "Pinguim":
                    AnimalName = "penguin";
                    break;

                case "Pombo":
                    AnimalName = "pigeon";
                    break;

                case "Tartatuga":
                    AnimalName = "turtle";

                    break;

                case "Tigre":
                    AnimalName = "tiger";
                    break;

                default:
                    return null;
            }


            //verifica o tipo de ação desejada
            switch (Action)
            {
                case "Alimentar":
                    Path += ("\\" + AnimalName + "\\actions\\feed\\video.3gp");
                    break;

                case "Ataque":
                    Path += ("\\" + AnimalName + "\\actions\\attack\\video.3gp");
                    break;

                case "Comunicar":
                    Path += ("\\" + AnimalName + "\\actions\\communicate\\video.3gp");
                    break;

                case "Movimentar":
                    Path += ("\\" + AnimalName + "\\actions\\walk\\video.3gp");
                    break;

                case "Voar":
                    Path += ("\\" + AnimalName + "\\actions\\fly\\video.3gp");
                    break;

                case "Ciscar":
                    Path += ("\\" + AnimalName + "\\actions\\scratch\\video.3gp");
                    break;

                case "Amamentar":
                    Path += ("\\" + AnimalName + "\\actions\\breastfeed\\video.3gp");
                    break;

                case "Botar":
                    Path += ("\\" + AnimalName + "\\actions\\lay_egg\\video.3gp");
                    break;

                case "Chocar":
                    Path += ("\\" + AnimalName + "\\actions\\hatch_the_egg\\video.3gp");
                    break;

                default:
                    return null;
            }

            return Path;
        }
    }
}
