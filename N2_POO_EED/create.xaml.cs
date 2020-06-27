using N2_POO_EED.Animais;
using N2_POO_EED.Classes_ancestrais_Animais;
using N2_POO_EED.Estruturas_de_dados;
using N2_POO_EED.Pasta_Animais;
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
    /// Lógica interna para create.xaml
    /// </summary>
    public partial class create : Window
    {

        public create()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Realiza a instância de um animal cada e os cadastra.
        /// </summary>
        private void InstanciarTodosAnimais()
        {
            Baleia b = new Baleia();
            b.Cor_pelos = "Marrom";
            b.Data_Nascimento = Convert.ToDateTime("07/05/2003");
            b.Nome = "Frih Wily";
            b.Sexo = 'm';
            b.QtMamas = 6;

            Cachorro c = new Cachorro();
            c.Cor_pelos = "Preto";
            c.Data_Nascimento = Convert.ToDateTime("05/11/2014");
            c.Nome = "Magrelin";
            c.QtMamas = 6;
            c.Sexo = 'm';

            Cobra cb = new Cobra();
            cb.Data_Nascimento = Convert.ToDateTime("06/08/2018");
            cb.Nome = "Jararaca";
            cb.Sexo = 'f';

            Coruja cj = new Coruja();
            cj.Cor_penas = "Cinza";
            cj.Data_Nascimento = Convert.ToDateTime("05/09/2016");
            cj.Nome = "Corujão";
            cj.Sexo = 'm';

            Gato gt = new Gato();
            gt.Cor_pelos = "Branco";
            gt.Data_Nascimento = Convert.ToDateTime("06/02/2017");
            gt.Nome = "Mia";
            gt.Sexo = 'f';
            gt.QtMamas = 4;

            Gaviao gv = new Gaviao();
            gv.Cor_penas = "Preto";
            gv.Data_Nascimento = Convert.ToDateTime("05/04/2013");
            gv.Nome = "Pópópó";
            gv.Sexo = 'm';

            Leao l = new Leao();
            l.Data_Nascimento = Convert.ToDateTime("20/12/2006");
            l.Nome = "Laranxxinha";
            l.QtMamas = 4;
            l.Sexo = 'f';
            l.Cor_pelos = "Laranja";

            Morcego m = new Morcego();
            m.Cor_pelos = "Marrom escuro";
            m.Data_Nascimento = Convert.ToDateTime("01/09/2019");
            m.Nome = "BatBat";
            m.QtMamas = 4;
            m.Sexo = 'f';

            Ornitorrinco o = new Ornitorrinco();
            o.Data_Nascimento = Convert.ToDateTime("15/07/2002");
            o.Cor_pelos = "Marrom";
            o.Nome = "Perry";
            o.QtMamas = 6;
            o.Sexo = 'm';

            Pato p = new Pato();
            p.Data_Nascimento = Convert.ToDateTime("16/02/2008");
            p.Nome = "Donald";
            p.Cor_penas = "Branco";
            p.Sexo = 'm';

            Pinguim pi = new Pinguim();
            pi.Data_Nascimento = Convert.ToDateTime("05/06/2013");
            pi.Nome = "Picolino";
            pi.Sexo = 'm';
            pi.Cor_penas = "Preto e Branco";

            Pombo po = new Pombo();
            po.Data_Nascimento = Convert.ToDateTime("14/09/2014");
            po.Cor_penas = "Cinza";
            po.Nome = "Jão";
            po.Sexo = 'm';

            Tartaruga t = new Tartaruga();
            t.Data_Nascimento = Convert.ToDateTime("17/12/1823");
            t.Nome = "Oogway";
            t.Sexo = 'm';

            Tigre ti = new Tigre();
            ti.Data_Nascimento = Convert.ToDateTime("19/05/2001");
            ti.Sexo = 'm';
            ti.QtMamas = 6;
            ti.Cor_pelos = "Laranja";
            ti.Nome = "König Tiger";


           
            Arvore.Insere(b);
            Arvore.Insere(c);
            Arvore.Insere(cb);
            Arvore.Insere(cj);
            Arvore.Insere(gv);
            Arvore.Insere(gt);
            Arvore.Insere(l);
            Arvore.Insere(m);
            Arvore.Insere(o);
            Arvore.Insere(p);
            Arvore.Insere(pi);
            Arvore.Insere(po);
            Arvore.Insere(t);
            Arvore.Insere(ti);
        }

        /// <summary>
        /// Evento click do botão que instancia todos os animais, com uma unidade de cada, automaticamente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_instanciarTodos_Click(object sender, RoutedEventArgs e)
        {
            InstanciarTodosAnimais();
            MessageBox.Show("Uma unidade de cada animal foi cadastrada.", "Cadastros realizados", MessageBoxButton.OK);
            LimparCampos();
        }

        /// <summary>
        /// Ao selecionar um item do combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // LimparCampos();

            switch (cb_tipoAnimal.SelectedIndex)
            {
                case 0: // Baleia
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 1: // Cachorro
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 2: // Cobra
                    HabilitarOuDesabilitarComponentes(false, false, false);
                    break;
                case 3: // Coruja
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 4: // Gato
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 5: // Gavião
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 6: // Leão
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 7: // Morcego
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 8: // Ornintorrinco
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
                case 9: // Pato
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 10: // Pinguim
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 11: // Pombo
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 12: // Tartaruga
                    HabilitarOuDesabilitarComponentes(false, true, false);
                    break;
                case 13: // Tigre
                    HabilitarOuDesabilitarComponentes(true, false, true);
                    break;
            }
        }

        /// <summary>
        /// Habilita ou desabilita as textbox txt_corPelos, txt_corPenas e txt_quantMama, baseada em parâmetros booleanos de forma respectiva.
        /// Isso impede que quando um tipo de animal é selecionado, o usuário possa selecionar campos que não façam sentido em relação a ele.
        /// </summary>
        /// <param name="txtPelos"></param>
        /// <param name="txtPenas"></param>
        /// <param name="txtMamas"></param>
        private void HabilitarOuDesabilitarComponentes(bool txtPelos, bool txtPenas, bool txtMamas)
        {
            lbl_corPelos.IsEnabled = txtPelos;
            lbl_corPenas.IsEnabled = txtPenas;
            lbl_quantMamas.IsEnabled = txtMamas;

            txt_corPelos.IsEnabled = txtPelos;
            txt_corPenas.IsEnabled = txtPenas;
            txt_quantMama.IsEnabled = txtMamas;
        }

        private bool VerificarCampoVazio(TextBox campo, string nomeCampo)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                MessageBox.Show($"O campo '{nomeCampo}' está vazio. Por favor, preencha este campo.");
                campo.Focus();
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Realiza a verificação de preenchimentos dos dois campos básicos: Nome, data de nascimento. Retorna true se estiver vazio ou false se estiver preechido.
        /// </summary>
        /// <returns></returns>
        private bool VerificarCamposBasicos()
        {
            DateTime d;

            if (VerificarCampoVazio(txt_nome, "nome"))
                return true;
            else if (VerificarCampoVazio(txt_dataNascimento, "data de nascimento"))
                return true;
            else if (!DateTime.TryParse(txt_dataNascimento.Text, out d))
            {
                MessageBox.Show("O campo 'data de nascimento' está com dados num formato incorreto. Por favor, corrija-o.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                txt_dataNascimento.Focus();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Limpa todos os campos da tela de cadastro.
        /// </summary>
        private void LimparCampos()
        {
            txt_corPelos.Clear();
            txt_corPenas.Clear();
            txt_quantMama.Clear();

            txt_dataNascimento.Clear();
            txt_nome.Clear();
        }

        private void Btn_cadastrar_Click(object sender, RoutedEventArgs e)
        {
            switch (cb_tipoAnimal.SelectedIndex)
            {
                case -1: // Nenhum item selecionado
                    MessageBox.Show("Por favor, selecione um tipo de animal no combobox e depois insira os dados necessários para o cadastro do mesmo.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);

                    break;
                case 0: // Baleia
                    Baleia b = new Baleia();
                    Cadastro(b);

                    break;
                case 1: // Cachorro
                    Cachorro c = new Cachorro();
                    Cadastro(c);

                    break;
                case 2: // Cobra
                    Cobra cb = new Cobra();
                    Cadastro(cb);

                    break;
                case 3: // Coruja
                    Coruja cj = new Coruja();
                    Cadastro(cj);

                    break;
                case 4: // Gato
                    Gato g = new Gato();
                    Cadastro(g);

                    break;
                case 5: // Gavião
                    Gaviao gv = new Gaviao();
                    Cadastro(gv);

                    break;
                case 6: // Leão
                    Leao l = new Leao();
                    Cadastro(l);

                    break;
                case 7: // Morcego
                    Morcego m = new Morcego();
                    Cadastro(m);

                    break;
                case 8: // Ornintorrinco
                    Ornitorrinco o = new Ornitorrinco();
                    Cadastro(o);

                    break;
                case 9: // Pato
                    Pato p = new Pato();
                    Cadastro(p);

                    break;
                case 10: // Pinguim
                    Pinguim pg = new Pinguim();
                    Cadastro(pg);

                    break;
                case 11: // Pombo
                    Pombo pb = new Pombo();
                    Cadastro(pb);

                    break;
                case 12: // Tartaruga
                    Tartaruga t = new Tartaruga();
                    Cadastro(t);

                    break;
                case 13: // Tigre
                    Tigre tg = new Tigre();
                    Cadastro(tg);

                    break;
            }
        }

        /// <summary>
        /// Se retornar true, o cadastro foi efetuado. Se não, algo de errado ocorreu.
        /// </summary>
        /// <param name="tipoAnimal"></param>
        /// <returns></returns>
        private void Cadastro(Animal tipoAnimal)
        {
            if (VerificarCamposBasicos())
                return;

            // Se os campos mais básicos não estiverem vazios, eles serão preenchidos.
            tipoAnimal.Nome = txt_nome.Text;
            tipoAnimal.Data_Nascimento = Convert.ToDateTime(txt_dataNascimento.Text);

            if (cb_sexo.SelectedIndex == 0)
                tipoAnimal.Sexo = 'm';
            else if (cb_sexo.SelectedIndex == 1)
                tipoAnimal.Sexo = 'f';

            // Verificação de que tipos de animais estão sendo cadastrados, verificando os seus próprios componentes.
            if (tipoAnimal is Ave)
            {
                // Verifica se o campo está vazio.
                if (VerificarCampoVazio(txt_corPelos, "cor das penas"))
                    return;

                // Se não estava vazio, realiza a inserção de fato.
                (tipoAnimal as Ave).Cor_penas = txt_corPenas.Text;
            }
            if (tipoAnimal is Mamifero)
            {
                // Também realiza as verificações de campos vazios, mas da forma mais específica pra o tipo de animal.
                if (VerificarCampoVazio(txt_corPelos, "cor dos pêlos"))
                    return;
                if (VerificarCampoVazio(txt_quantMama, "quantidade de mamas"))
                    return;

                // Se o campo 'quantidade de mamas' não estiver vazio, ainda assim precisará verificar se é um número inteiro válido.
                int quantMamas;
                if (!int.TryParse(txt_quantMama.Text, out quantMamas))
                {
                    MessageBox.Show("O campo 'quantidade de mamas' está num formato incorreto. Por favor, escreva um valor inteiro válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Caso tenha passado por todas as verificações, pode-se enfim atribuir as propriedades do mamífero.
                (tipoAnimal as Mamifero).Cor_pelos = txt_corPelos.Text;
                (tipoAnimal as Mamifero).QtMamas = quantMamas;
            }

            Arvore.Insere(tipoAnimal); // Realiza, por fim, a inserção.

            MessageBox.Show("Animal cadastrado!", "Cadastro realizado", MessageBoxButton.OK);
            LimparCampos();
        }

        /// <summary>
        /// Evento click que leva até a página de visualização do animal, especificamente para o último animal que foi cadastrado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_verAnimalCadastrado_Click(object sender, RoutedEventArgs e)
        {
            // Passa os parâmetros para essa página citada para que ela possa indentificar a posição desse animal na lista e efetuar suas ações.

            animalActions action = new animalActions();
            action.ShowDialog();
        }
    }
}

