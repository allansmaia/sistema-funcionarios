using System;

namespace SistemaFuncionarios
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }
        public int CargoId { get; set; }
        public int DepartamentoId { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }
        public bool Ativo { get; set; }

        public Funcionario(int id, string nome, string cpf, string email, int idade, int cargoId, int departamentoId, decimal salario)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Idade = idade;
            CargoId = cargoId;
            DepartamentoId = departamentoId;
            Salario = salario;
            DataAdmissao = DateTime.Now;
            Ativo = true;
        }
    }
}
