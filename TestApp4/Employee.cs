
namespace TestApp4
{
    internal class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int Section { get; set; }
        public int Year { get; set; }
        public double Salary { get; set; }

        double Tax => Salary * 0.05;

        double Net => (Salary - Tax) + Bonus();

        double Bonus()
        {

            double RateBonus = Section switch
            {
                1 => Year >= 2 ? 3 : 2,
                2 => Year >= 2 ? 4 : 3,
                3 => Year >= 3 ? 3 : 2,
                4 => Year >= 3 ? 3.5 : 2.5,
                5 => Year >= 4 ? 4 : 3.5,
                _ => 0 
            };

            return Salary * RateBonus;
        }

        public void Display()
        {
            Console.WriteLine($"{Id} {Section,5} {Year,5} {Salary,10} {Tax,10:N2} {Bonus(),10:N2} {Net,10:N2}");
        }

    }
}


//Id section   year	salary		tax	bonus		net