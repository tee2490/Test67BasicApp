﻿namespace ConsoleApp3
{
    //ทำอะไร What?
    internal interface IServiceProduct
    {

        //Method
        void Display();
        void Create(int number);
        void Add(Product product);
        void Update();
        void Delete(int id);
    }
}