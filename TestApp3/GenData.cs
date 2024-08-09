

namespace TestApp3
{
    internal class GenData
    {
        List<Employee> EmployeesList { get; set; }

        public GenData()
        {
            EmployeesList = new List<Employee>();   
        }

        public void Create(int number = 10,int days = 7)
        {
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                var hours = new List<int>();
                for (int j = 0; j < days; j++)
                {
                    hours.Add( random.Next(1,5));
                }

                EmployeesList.Add(new Employee { Hours = hours });
            }
        }


        public void Display()
        {
            foreach (var e in EmployeesList)
            {
                Console.Write($"{e.Id,5}");

                foreach (var item in e.Hours)
                {
                    Console.Write($"{item,5}");
                }

                Console.WriteLine($"{e.CalculateOT(),10}");

            }
        }


    }
}
