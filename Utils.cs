using System;

namespace SistemaFuncionarios
{
    public static class Utils
    {
        public static int GerarIdFuncionario()
        {
            return Dados.ProximoIdFuncionario++;
        }

        public static int GerarIdDepartamento()
        {
            return Dados.ProximoIdDepartamento++;
        }

        public static int GerarIdCargo()
        {
            return Dados.ProximoIdCargo++;
        }

        public static int GerarIdFolha()
        {
            return Dados.ProximoIdFolha++;
        }

        public static string FormatarMoeda(decimal valor)
        {
            return valor.ToString("C2");
        }

        public static string FormatarData(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
        }

        public static void ExibirSeparador()
        {
            Console.WriteLine("================================");
        }

        public static void ExibirTitulo(string titulo)
        {
            ExibirSeparador();
            Console.WriteLine(titulo);
            ExibirSeparador();
        }
    }
}
