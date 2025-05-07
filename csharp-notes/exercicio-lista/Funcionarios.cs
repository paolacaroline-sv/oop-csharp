
namespace exercicio_lista
{
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double aumento)
        {
            double total = Salario / 100 * aumento;
            Salario += total;
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario;
        }
    }
}
