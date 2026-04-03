using System;

namespace SistemaFuncionarios
{
    public class Folha
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public decimal SalarioBruto { get; set; }
        public decimal Inss { get; set; }
        public decimal Irrf { get; set; }
        public decimal ValeTransporte { get; set; }
        public decimal ValeRefeicao { get; set; }
        public decimal SalarioLiquido { get; set; }
        public DateTime Competencia { get; set; }

        public Folha(int id, int funcionarioId, decimal salarioBruto)
        {
            Id = id;
            FuncionarioId = funcionarioId;
            SalarioBruto = salarioBruto;
            Inss = CalcularInss(salarioBruto);
            Irrf = CalcularIrrf(salarioBruto);
            ValeTransporte = 220;
            ValeRefeicao = 550;
            SalarioLiquido = salarioBruto - Inss - Irrf + ValeTransporte + ValeRefeicao;
            Competencia = DateTime.Now;
        }

        private static decimal CalcularInss(decimal salario)
        {
            if (salario <= 1412) return salario * 0.075m;
            if (salario <= 2666) return salario * 0.09m;
            if (salario <= 4000) return salario * 0.12m;
            return salario * 0.14m;
        }

        private static decimal CalcularIrrf(decimal salario)
        {
            if (salario <= 2259) return 0;
            if (salario <= 2826) return salario * 0.075m;
            if (salario <= 3751) return salario * 0.15m;
            if (salario <= 4664) return salario * 0.225m;
            return salario * 0.275m;
        }
    }
}
