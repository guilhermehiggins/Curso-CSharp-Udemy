using System.Globalization;

namespace ExercicioArquivos.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal(double preco, int quantidade)
        {
            return Total = preco / 100.00 * quantidade;
        }

        public override string ToString()
        {
            return $"{Nome}; {Total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
