using ConsoleApp4.Models;
using System.IO;

namespace ConsoleApp4.Data
{
    public class GenData
    {
        List<Product> ProductList { get; set; }
        String fullPath = "E:\\cs67\\Basic\\BasicApp\\ConsoleApp4\\Test.txt";

        public GenData()
        {
            ProductList = new List<Product>();
            Create();
            WriteToFile();
        }

        public void Create(int number = 10)
        {
            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                Product product = new Product()
                {
                    Id = i,
                    Name = "ROV" + i,
                    Price = random.Next(10, 1000) + random.NextDouble(),
                    Amount = random.Next(10, 20)
                };

                ProductList.Add(product);
            }
        }

        public void WriteToFile()
        {

            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (var item in ProductList)
                {
                    writer.WriteLine($"{item.Id} {item.Name} " +
                        $"{item.Price.ToString("##.##")} {item.Amount}");
                }
                writer.Close();
            }

        }

        public bool CheckFile()
        {
            if (!File.Exists(fullPath))
            {
                Console.WriteLine("File not found");
                return true;
            }

            return false;
        }

        public void ReadFromFile()
        {
            if (CheckFile()) return;

            var products = File.ReadAllText(fullPath);
            Console.WriteLine(products);
        }

        public void Display()
        {

            if (CheckFile()) return;

            foreach (string line in File.ReadLines(fullPath))
            {
                var data = line.Split(' ');

                var p = new Product()
                {
                    Id = Convert.ToInt32(data[0]),
                    Name = data[1],
                    Price = Convert.ToDouble(data[2]),
                    Amount = Convert.ToInt32(data[3])
                };

                Console.WriteLine($"{p.Id,5} {p.Name,10} {p.Price,10:N2} " +
                    $"{p.Amount,5} {p.TotalPrice,10:N2}");
            }
        }



    }
}
