using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2_POO_EED.Classes_ancestrais_Animais
{
    abstract class Animal
    {
        private string nome;
        private DateTime dataNascimento;
        protected char sexo;
        protected bool carnivoro;
        protected bool peconhento;


        public Animal(string _nome, DateTime _data, char _sexo)
        {
            Nome = _nome;
            Data_Nascimento = _data;
            Sexo = _sexo;
        }
        public Animal()
        {
            
        }
        public  bool Carnivoro
        {
            get { return carnivoro; }
        }
        public bool Peconhento
        {
            get { return peconhento; }
        }
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == "")
                    throw new Exception("O nome do animal não pode estar vazio!");
                else
                    nome = value;
            }
        }
        public DateTime Data_Nascimento
        {
            get { return dataNascimento; }
            set
            {
                if (value == null)
                    throw new Exception("A data não pode ser nula!");
                else if (value>DateTime.Now)
                    throw new Exception("A data de nascimento não pode ser maior que a data atual");
                else
                    dataNascimento = value;
            }
        }
        public  char Sexo 
        {
            get { return sexo; }
            set
            {
                if (value.ToString().ToUpper() != "M" && value.ToString().ToUpper() != "F")
                    throw new Exception("Sexo inválido!");
                else
                    sexo = value.ToString().ToUpper()[0];
            }
        }

        public int Idade()
        {
            if (dataNascimento == null)
                throw new Exception("A idade do animal não pode ser calculada! pois a data de nascimento não foi informada!");
            else
                return (int)(DateTime.Now.Subtract(dataNascimento).TotalDays);
        }

        public override string ToString()
        {
            return $"Nome: {nome} " + Environment.NewLine + $"Data De Nascimento: {dataNascimento.ToShortDateString()}" + Environment.NewLine
                + $"Sexo: {sexo}" + Environment.NewLine + $"Carnívoro? {(carnivoro == true ? "Sim" : "Não")}" + Environment.NewLine
                + $"Peçonhento? {(peconhento == true ? "Sim" : "Não")}" + Environment.NewLine;
        }

        public abstract string Movimentar();

        public abstract string Comunicar();

        public abstract string Alimentar();

    }
}
