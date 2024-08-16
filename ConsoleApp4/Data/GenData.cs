using ConsoleApp4.Models;

namespace ConsoleApp4.Data
{
    public class GenData
    {
        List<Product> ProductList { get; set; }

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
                    Id =i,
                     Name = "ROV"+i,
                     Price = random.Next(10,1000)+random.NextDouble(),
                     Amount = random.Next(10,20)
                };

                ProductList.Add(product);
            }
        }

        public void WriteToFile()
        {
            var fullPath = "E:\\cs67\\Basic\\BasicApp\\ConsoleApp4\\Test.txt";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                foreach (var item in ProductList)
                {
                    writer.WriteLine($"{item.Id} {item.Name} {item.Price.ToString("##.##")} {item.Amount}");
                }
                writer.Close();
            }
        
        }



    }
}
