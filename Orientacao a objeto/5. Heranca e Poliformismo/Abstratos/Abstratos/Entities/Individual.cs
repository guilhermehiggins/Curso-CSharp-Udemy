using System.Globalization;

namespace Abstratos.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpend { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpend) : base(name, anualIncome)
        {
            HealthExpend = healthExpend;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome <= 20000.00)
            {
                return ((AnualIncome * 0.15) / 100.0) - (HealthExpend * 0.5);
            }
            else
            {
                return ((AnualIncome * 0.25) / 100.0) - (HealthExpend * 0.5);
            }
        }

        public override string ToString()
        {
            return Name
                + ": $"
                + TaxesPaid().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
