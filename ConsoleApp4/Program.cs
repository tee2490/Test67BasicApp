
using ConsoleApp4.Data;

var ps = new GenData();

//สร้าง ของเดิมหายหมด
//ps.Create();
//ps.WriteToFile();
//ps.Display();
//ps.ReadFromFile();

//เพิ่มได้
//ps.Add(5);

//ลบ ค้นด้วย id
ps.ReadFileToList();
ps.DisplayProductList();

Console.WriteLine();

ps.Delete(15);
//ps.DisplayProductList();
ps.WriteToFile();
Console.WriteLine();
ps.ReadFromFile();




