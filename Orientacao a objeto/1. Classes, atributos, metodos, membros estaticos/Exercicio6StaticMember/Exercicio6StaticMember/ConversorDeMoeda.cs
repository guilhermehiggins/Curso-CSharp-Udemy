namespace Exercicio6StaticMember
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Valor(double cotacao, double qtdDolar)
        {
            return cotacao * qtdDolar * Iof + (cotacao * qtdDolar);
        }
    }
}
