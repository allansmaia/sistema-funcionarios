namespace SistemaFuncionarios
{
    public static class Validacao
    {
        public static bool ValidarNome(string nome)
        {
            return !string.IsNullOrWhiteSpace(nome) && nome.Length >= 3;
        }

        public static bool ValidarCpf(string cpf)
        {
            return !string.IsNullOrWhiteSpace(cpf) && cpf.Length == 11;
        }

        public static bool ValidarSalario(decimal salario)
        {
            return salario >= 1412;
        }

        public static bool ValidarIdade(int idade)
        {
            return idade >= 18 && idade <= 70;
        }

        public static bool ValidarEmail(string email)
        {
            return !string.IsNullOrWhiteSpace(email) && email.Contains("@");
        }
    }
}
