namespace SistemaFuncionarios
{
    public class Cargo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public int DepartamentoId { get; set; }
        public Cargo(int id, string nome, decimal salarioBase, int departamentoId)
        {
            Id = id;
            Nome = nome;
            SalarioBase = salarioBase;
            DepartamentoId = departamentoId;
        }
    }
}
