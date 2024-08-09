
namespace TestApp3
{
    internal class Employee
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public List<int> Hours { get; set; } = new();

        public double CalculateOT()
        {
            var Rate = 0;
            var SumOT = 0;

            for (int i = 0; i < Hours.Count; i++)
            {
                Rate = i > 4 ? 40 : 30;

                SumOT += Hours[i] * Rate;

            }

            return SumOT;
        }


    }
}
