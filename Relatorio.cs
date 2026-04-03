using System;
using System.Linq;

namespace SistemaFuncionarios
{
    public static class Relatorio
    {
        public static void RelatorioFuncionariosPorDepartamento()
        {
            Utils.ExibirTitulo("RELATORIO - Funcionarios por Departamento");
            foreach (var depto in Dados.Departamentos)
            {
                Console.WriteLine($"\nDepartamento: {depto.Nome}");
                Utils.ExibirSeparador();
                var funcionarios = Dados.Funcionarios.Where(f => f.DepartamentoId == depto.Id).ToList();
                if (!funcionarios.Any())
                {
                    Console.WriteLine("Nenhum funcionario neste departamento.");
                    continue;
                }
                foreach (var f in funcionarios)
                {
                    var cargo = Dados.Cargos.FirstOrDefault(c => c.Id == f.CargoId);
                    Console.WriteLine($"#{f.Id} | {f.Nome} | {cargo?.Nome} | {Utils.FormatarMoeda(f.Salario)}");
                }
            }
        }

        public static void RelatorioFolhaPagamento()
        {
            Utils.ExibirTitulo("RELATORIO - Folha de Pagamento");
            foreach (var folha in Dados.Folhas)
            {
                var funcionario = Dados.Funcionarios.FirstOrDefault(f => f.Id == folha.FuncionarioId);
                Console.WriteLine($"\nFuncionario: {funcionario?.Nome}");
                Console.WriteLine($"Salario Bruto:    {Utils.FormatarMoeda(folha.SalarioBruto)}");
                Console.WriteLine($"INSS:             -{Utils.FormatarMoeda(folha.Inss)}");
                Console.WriteLine($"IRRF:             -{Utils.FormatarMoeda(folha.Irrf)}");
                Console.WriteLine($"Vale Transporte:  +{Utils.FormatarMoeda(folha.ValeTransporte)}");
                Console.WriteLine($"Vale Refeicao:    +{Utils.FormatarMoeda(folha.ValeRefeicao)}");
                Utils.ExibirSeparador();
                Console.WriteLine($"Salario Liquido:  {Utils.FormatarMoeda(folha.SalarioLiquido)}");
                Utils.ExibirSeparador();
            }
        }

        public static void ResumoGeral()
        {
            Utils.ExibirTitulo("RESUMO GERAL");
            Console.WriteLine($"Total de funcionarios: {Dados.Funcionarios.Count}");
            Console.WriteLine($"Total de departamentos: {Dados.Departamentos.Count}");
            Console.WriteLine($"Total de cargos: {Dados.Cargos.Count}");
            var totalFolha = Dados.Folhas.Sum(f => f.SalarioLiquido);
            Console.WriteLine($"Total folha de pagamento: {Utils.FormatarMoeda(totalFolha)}");
        }
    }
}
