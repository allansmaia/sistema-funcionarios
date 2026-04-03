using System;

namespace SistemaFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de Gestao de Funcionarios ===\n");

            // Criando departamentos
            Console.WriteLine("--- Criando departamentos ---");
            var ti = new Departamento(Utils.GerarIdDepartamento(), "Tecnologia", "Desenvolvimento de software");
            var rh = new Departamento(Utils.GerarIdDepartamento(), "Recursos Humanos", "Gestao de pessoas");
            var fin = new Departamento(Utils.GerarIdDepartamento(), "Financeiro", "Gestao financeira");
            Dados.Departamentos.Add(ti);
            Dados.Departamentos.Add(rh);
            Dados.Departamentos.Add(fin);
            Console.WriteLine("3 departamentos criados com sucesso!");

            // Criando cargos
            Console.WriteLine("\n--- Criando cargos ---");
            var devJr = new Cargo(Utils.GerarIdCargo(), "Desenvolvedor Junior", 3000, ti.Id);
            var devPl = new Cargo(Utils.GerarIdCargo(), "Desenvolvedor Pleno", 6000, ti.Id);
            var analista = new Cargo(Utils.GerarIdCargo(), "Analista de RH", 4000, rh.Id);
            var controller = new Cargo(Utils.GerarIdCargo(), "Controller", 8000, fin.Id);
            Dados.Cargos.Add(devJr);
            Dados.Cargos.Add(devPl);
            Dados.Cargos.Add(analista);
            Dados.Cargos.Add(controller);
            Console.WriteLine("4 cargos criados com sucesso!");

            // Criando funcionarios
            Console.WriteLine("\n--- Criando funcionarios ---");
            var f1 = new Funcionario(Utils.GerarIdFuncionario(), "Allan Maia", "12345678901", "allan@empresa.com", 25, devJr.Id, ti.Id, 3000);
            var f2 = new Funcionario(Utils.GerarIdFuncionario(), "Maria Silva", "98765432100", "maria@empresa.com", 32, devPl.Id, ti.Id, 6000);
            var f3 = new Funcionario(Utils.GerarIdFuncionario(), "Joao Santos", "11122233344", "joao@empresa.com", 28, analista.Id, rh.Id, 4000);
            var f4 = new Funcionario(Utils.GerarIdFuncionario(), "Ana Costa", "55566677788", "ana@empresa.com", 40, controller.Id, fin.Id, 8000);
            Dados.Funcionarios.Add(f1);
            Dados.Funcionarios.Add(f2);
            Dados.Funcionarios.Add(f3);
            Dados.Funcionarios.Add(f4);
            Console.WriteLine("4 funcionarios criados com sucesso!");

            // Gerando folha de pagamento
            Console.WriteLine("\n--- Gerando folha de pagamento ---");
            foreach (var func in Dados.Funcionarios)
            {
                var folha = new Folha(Utils.GerarIdFolha(), func.Id, func.Salario);
                Dados.Folhas.Add(folha);
            }
            Console.WriteLine("Folha de pagamento gerada com sucesso!");

            // Relatorios
            Console.WriteLine("\n");
            Relatorio.RelatorioFuncionariosPorDepartamento();
            Console.WriteLine("\n");
            Relatorio.RelatorioFolhaPagamento();
            Console.WriteLine("\n");
            Relatorio.ResumoGeral();

            // Testando validacoes
            Console.WriteLine("\n--- Testando validacoes ---");
            Console.WriteLine(Validacao.ValidarCpf("123") ? "CPF valido" : "Erro: CPF invalido");
            Console.WriteLine(Validacao.ValidarSalario(500) ? "Salario valido" : "Erro: Salario abaixo do minimo");
            Console.WriteLine(Validacao.ValidarIdade(15) ? "Idade valida" : "Erro: Idade invalida");
        }
    }
}
