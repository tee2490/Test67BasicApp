namespace ConsoleApp1
{
    internal class Product
    {
        //properties คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        static public string Company {  get; set; } //สามารถเข้าถึงโดยตรง มันอยู่ใน memory

        public Product() //Contructor 
        {
            Id = 1;
            Name = "Coffee";
            Price = 100;
            Amount = 20;
        }

        public Product(int Id,string name,double price,int amount) //parameter
        {
            this.Id = Id; //บ่งบอกค่าในคลาส
            Name = name;
            Price = price;
            Amount = amount;
        }

        public void Display() //Method
        {
            Console.WriteLine($"{Id} {Name} {Price} {Amount} {Company}");
        }


    }
}
