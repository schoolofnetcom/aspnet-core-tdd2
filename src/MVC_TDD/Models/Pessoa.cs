using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TDD.Models
{
    public class Pessoa
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string cpf, string nome)
        {
            if (String.IsNullOrEmpty(cpf))
                throw new Exception("CPF é obrigatório.");

            if (String.IsNullOrEmpty(nome))
                throw new Exception("Nome é obrigatório.");

            this.CPF = cpf;
            this.Nome = nome;
        }

        public bool IsMaiorIdade()
        {
            var idade = DateTime.Now.Year - this.DataNascimento.Year;
            if (DateTime.Now.DayOfYear < this.DataNascimento.DayOfYear)
                idade--;
            return idade >= 18;
        }
    }
}
