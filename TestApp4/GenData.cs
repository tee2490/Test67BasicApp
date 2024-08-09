
using static System.Collections.Specialized.BitVector32;

namespace TestApp4
{
    internal class GenData
    {
        List<Employee> EmployeeList;

        public GenData()
        {
            EmployeeList = new();
        }

        public void Create(int number = 10)
        {
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                EmployeeList.Add(new Employee
                {
                    Section = random.Next(1, 6),
                    Salary = random.Next(1000, 5000),
                    Year = random.Next(2, 5)
                });
            }
        }

        public void Show()
        {
            Console.WriteLine($"{"Id"} {"Sec.",40} {"Year",5} {"Salary",10} {"Tax",10} {"Bonus",10} {"Net",10}");
            foreach (var item in EmployeeList)
            {
                item.Display();
            }
        }

        public void ShowByGroup()
        {
            var groupEmployee = EmployeeList
                                .OrderBy(x => x.Section)
                                .GroupBy(x => x.Section).ToList(); //จัดกลุ่ม

            foreach (var group in groupEmployee)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine($"{"Id"} {"Sec.",40} {"Year",5} {"Salary",10} {"Tax",10} {"Bonus",10} {"Net",10}");

                //แต่ละกลุ่ม
                foreach (var e in group)
                {
                    e.Display();
                }

                Console.WriteLine();
            }

        }


    }
}
