﻿namespace ConsoleApp1
{
    public class Product
    {
        //properties คุณสมบัติ
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        static public string Company {  get; set; } //สามารถเข้าถึงโดยตรง มันอยู่ใน memory
        private double SpecialIngrediant { get; set; }
        protected double SpecialIngrediant1 { get; set; }
        internal double SpecialIngrediant2 { get; set; }

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


        //virtual (Overide Method)
        public virtual void Display() //Method
        {
            Console.WriteLine($"{Id} {Name} {Price} {Amount} {Company} " +
                $"{SpecialIngrediant} {SpecialIngrediant1}");
        }

        //กำหนดค่า private แบบทางอ้อม
        public double SetSpecialbyTa(double SpecialIngrediant=999) 
        {
            this.SpecialIngrediant = SpecialIngrediant * 2 / 0.74532;

            return this.SpecialIngrediant;
        }
    
        public double SetSpecial2(double SpecialIngrediant2)
        {
            SpecialIngrediant2 = SpecialIngrediant2 * 2 + 0.999;
            return this.SpecialIngrediant2;
        }


    }
}
