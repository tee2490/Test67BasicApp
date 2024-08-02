
//สืบทอดมาจาก Product
namespace ConsoleApp1
{
    internal class SuperCar : Product,Test
    {
        //protected สืบทอดได้ แต่ต้องเข้าหาแบบอ้อม
        public double SetSepicial1(double SpecialIngrediant1 = 0)
        {
            this.SpecialIngrediant1 = SpecialIngrediant1 + .0001 * 1.000254;
            return this.SpecialIngrediant1;
        }

        public override void Display() //Overide Method
        {
            Console.WriteLine("Overide Display");
            Console.WriteLine($"{Id} {Name} {Price} {Amount} {Company} " +
                $"{SpecialIngrediant1}");
        }
    }
}
