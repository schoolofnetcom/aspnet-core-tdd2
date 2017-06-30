using MVC_TDD.Models;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_TDD.Tests.Models
{
    [TestFixture]
    public class PessoaTest
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //Executa uma vez antes de todos os testes
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //Executa uma vez ao final de todos os testes
        }

        [SetUp]
        public void SetUp()
        {
            //Executa uma vez antes de cada método de teste 
        }

        [TearDown]
        public void TearDown()
        {
            //Executa uma vez depois de cada método de teste 
        }

        [TestCase("01234567890", "Joao")]
        [TestCase("00000000000", "Maria")]
        [TestCase("99999999999", "Pedro")]
        public void Pessoa_Criar(string cpf, string nome)
        {
            //RN00: Pessoa deve ter CPF e Nome
            Pessoa p = new Pessoa(cpf, nome);
            Assert.IsTrue(!String.IsNullOrEmpty(p.CPF), "CPF é Obrigatório");
            Assert.IsTrue(!String.IsNullOrEmpty(p.Nome), "Nome é Obrigatório");
        }

        [Test]
        [Ignore("Foco em criação")]
        public void Pessoa_Maior_Idade()
        {
            //RN01: Pessoa é maior de idade (>= 18 anos)
            Pessoa p = new Pessoa("01234567890", "Joao");
            p.DataNascimento = new DateTime(1999, 5, 1);
            Assert.IsTrue(p.IsMaiorIdade(), "Não é maior de idade.");
        }

        [Test]
        public void Pessoa_CPF_Exception()
        {
            //RN02: Deve lançar exceção quando CPF nulo
            ActualValueDelegate<object> pessoa = () => new Pessoa(null, "Joao");
            Assert.That(pessoa, Throws.TypeOf<Exception>());
        }
    }
}
