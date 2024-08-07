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
                var name = FakeData.NameOfProduct[ r.Next(0,count)  ];
                var price = r.Next(10,101);
                var amount = r.Next(10, 1000);         

                ProductList.Add(new Product(id,name,price,amount));
            }

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine(ProductList.Count);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
