using System.Globalization;

namespace Abstratos.Entities
{
    class Company : Taxpayer
    {
        public int EmployeesNumber { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double TaxesPaid()
        {
            if (EmployeesNumber <= 10)
            {
                return AnualIncome * 0.16 / 100.0;
            }
            else
            {
                return AnualIncome * 0.14 / 100.0;
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
