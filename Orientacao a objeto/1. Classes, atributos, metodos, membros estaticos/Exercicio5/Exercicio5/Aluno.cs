using System;
using System.Globalization;

namespace Exercicio5
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public override string ToString()
        {
            if (NotaFinal() >= 60)
            {
                return "NOTA FINAL: "
                    + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                    + "\nAPROVADO";
            }
            else
            {
                return "NOTA FINAL: "
                     + NotaFinal().ToString("F2", CultureInfo.InvariantCulture)
                     + "\nREPROVADO\n"
                     + "FALTARAM: "
                     + ((60.0 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture)
                     + " PONTOS");
            }
        }
    }
}
