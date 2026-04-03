using System.Collections.Generic;

namespace SistemaFuncionarios
{
    public static class Dados
    {
        public static List<Funcionario> Funcionarios = new List<Funcionario>();
        public static List<Departamento> Departamentos = new List<Departamento>();
        public static List<Cargo> Cargos = new List<Cargo>();
        public static List<Folha> Folhas = new List<Folha>();
        public static int ProximoIdFuncionario = 1;
        public static int ProximoIdDepartamento = 1;
        public static int ProximoIdCargo = 1;
        public static int ProximoIdFolha = 1;
    }
}
