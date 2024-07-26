namespace ConsoleApp1
{
    internal class GenerateProduct
    {
        List<Product> products; //ตัวแปรทั่วไป

        public GenerateProduct() //เริ่มต้น
        {
            products = new List<Product>(); //object
        }

        public void Create(int num = 5) //ค่าตั้งต้น default
        {
            Random r = new Random();

            for (int i = 0; i < num; i++)
            {
                products.Add(new Product
                {
                    Id = i,
                    Name = "Product" + i,
                    Price = r.Next(10, 1000) + r.NextDouble(),
                    Amount = r.Next(1, 100)
                });
            }
        }

        public void DisPlay()
        {
            foreach (var item in products)
            {
                var totalPrice = item.Price * item.Amount;
                Console.WriteLine($"{item.Id,5} {item.Name,10} {item.Price,8:N2} " +
                    $"{item.Amount,5} {totalPrice,10:N2} {Rating(totalPrice),8}");
            }
        }

        public void MaxPrice(int FirstLevel = 5)
        {
            FirstLevel = FirstLevel == 0 ? products.Count() : FirstLevel;

            products = products.OrderByDescending(x => x.Price)
                               .Take(FirstLevel).ToList(); //LingQ

        }

        public string Rating(double totalprice) //ส่งค่ากลับชนิดข้อความ
        {
            var star = totalprice switch
            {
                > 30000 => "***",
                > 20000 => "**",
                _ => "*"

            };

            return star;
        }


    }
}
