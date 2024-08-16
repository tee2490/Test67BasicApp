// Write file using StreamWriter

var fullPath = "E:\\cs67\\Basic\\BasicApp\\ConsoleApp4\\Test.txt";
using (StreamWriter writer = new StreamWriter(fullPath))
{
    writer.WriteLine("Monica Rathbun");
    writer.WriteLine("Vidya Agarwal");
    writer.WriteLine("Mahesh Chand");
    writer.WriteLine("Vijay Anand");
    writer.WriteLine("Jignesh Trivedi");
}
// Read a file
string readText = File.ReadAllText(fullPath);
Console.WriteLine(readText);