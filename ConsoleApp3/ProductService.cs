namespace ConsoleApp3
{
    internal class ProductService : IServiceProduct
    {
        List<Product> ProductList { get; set; }

        public ProductService()
        {
            ProductList = new List<Product>();
        }

        public void Create(int number = 5)
        {
            Random r = new Random();

            for (int i = 0; i < number; i++)
            {
                var id = i;

                var count = FakeData.NameOfProduct.Count;
                var name = FakeData.NameOfProduct[r.Next(0, count)];
                var price = r.Next(10, 101) + r.NextDouble();
                var amount = r.Next(10, 100);

                ProductList.Add(new Product(id, name, price, amount));
            }

        }

        public void Delete(int id)
        {
            var product = ProductList.FirstOrDefault(p => p.Id.Equals(id));

            //ค้นพบ
            if (product != null)
            {
                ProductList.Remove(product);

                Console.WriteLine($"*****Delete id {product.Id} ******");
                Display();
            }
            else Console.WriteLine($"***** Not Found id {id} ******");
        }

        public void Display()
        {
            foreach (var p in ProductList)
            {
                var name = p.Name.Length > 15 ? p.Name.Substring(0, 15) : p.Name;

                Console.WriteLine($"{p.Id,5} {name,15} " +
                    $"{p.Price,8:N2} {p.Amount,8}");
            }
        }

        public void Update()
        {
            //แก้ทั้งหมด หรือ บางส่วน
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
        }
    }
}
