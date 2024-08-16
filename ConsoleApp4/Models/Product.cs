namespace ConsoleApp4.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public double TotalPrice => Price*Amount;

        public void DisplayProduct() 
        {
            Console.WriteLine($"{Id,5} {Name,10} {Price,10:N2} " +
                $"{Amount,10:N2} {TotalPrice,10:N2}");
        }

    }
}
