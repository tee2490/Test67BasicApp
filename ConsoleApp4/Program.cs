
using ConsoleApp4.Data;
using ConsoleApp4.Models;

var ps = new GenData();

//สร้าง ของเดิมหายหมด
//ps.Create();
//ps.WriteToFile();
//ps.Display();
//ps.ReadFromFile();

//เพิ่มได้
//ps.Add(5);

//ลบ ค้นด้วย id
//ps.ReadFileToList();
//ps.DisplayProductList();

//Console.WriteLine();

//ps.Delete(15);
////ps.DisplayProductList();
//ps.WriteToFile();
//Console.WriteLine();
//ps.ReadFromFile();

//Update
ps.ReadFileToList();
ps.Update(new Product { Id=0,Name="Test",Price=99.99,Amount=10});
Console.WriteLine();
ps.DisplayProductList();

Console.WriteLine();
ps.WriteToFile();
ps.ReadFromFile();





