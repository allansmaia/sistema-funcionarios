# Sistema de Gestao de Funcionarios

Sistema desenvolvido em C# para simular a gestao completa de funcionarios de uma empresa.

## Estrutura do projeto

- `Dados.cs` - Banco de dados simulado em memoria
- `Validacao.cs` - Validacoes de CPF, salario e dados
- `Utils.cs` - Funcoes utilitarias e formatacao
- `Departamento.cs` - Modelo de departamento
- `Cargo.cs` - Modelo de cargo
- `Funcionario.cs` - Modelo de funcionario
- `Folha.cs` - Calculo de folha de pagamento
- `Relatorio.cs` - Geracao de relatorios
- `Program.cs` - Ponto de entrada do sistema

## Funcionalidades

- Cadastro de departamentos e cargos
- Cadastro de funcionarios com validacao de dados
- Calculo automatico de INSS e IRRF
- Beneficios de vale transporte e vale refeicao
- Relatorio de funcionarios por departamento
- Relatorio detalhado de folha de pagamento
- Resumo geral do sistema

## Como executar

dotnet run

## Versionamento

- v1.0.0 - Estrutura inicial do projeto
- v1.1.0 - Cadastros e validacoes
- v1.2.0 - Folha de pagamento
- v1.3.0 - Relatorios e sistema completo
