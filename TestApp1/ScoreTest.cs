using System.Linq;

namespace TestApp1
{
    internal class ScoreTest
    {
        public int Id { get; set; }
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Test3 { get; set; }
        public double Test4 { get; set; }

        public double sum => Test1 + Test2 + Test3 + Test4;
        public double ave => sum / 4;

        static List<ScoreTest> scoreTest = new List<ScoreTest>();

        public void Create(int number = 5)
        {
            Random r = new Random();
            for (int i = 0; i < number; i++)
                scoreTest.Add(new ScoreTest
                {
                    Id = i+1,
                    Test1 = r.Next(1, 100),
                    Test2 = r.Next(1, 100),
                    Test3 = r.Next(1, 100),
                    Test4 = r.Next(1, 100),

                });

        }

        public void Display()
        {
            foreach (var item in scoreTest)
            {
                Console.WriteLine($"{item.Id,1}\t {item.Test1,10} {item.Test2,10} {item.Test3,10} {item.Test4,10}" +
                    $" \t{item.sum} \t {item.ave:n2}");
            }
        }

        public void FootSummary()
        {
            double[] ave = new double[4];
            double[] max = new double[4];
            double[] min = new double[4];

            ave[0] = scoreTest.Average(x => x.Test1);
            ave[1] = scoreTest.Average(x => x.Test2);
            ave[2] = scoreTest.Average(x => x.Test3);
            ave[3] = scoreTest.Average(x => x.Test4);

            max[0] = scoreTest.Max(x => x.Test1);
            max[1] = scoreTest.Max(x => x.Test2);
            max[2] = scoreTest.Max(x => x.Test3);
            max[3] = scoreTest.Max(x => x.Test4);

            min[0] = scoreTest.Min(x => x.Test1);
            min[1] = scoreTest.Min(x => x.Test2);
            min[2] = scoreTest.Min(x => x.Test3);
            min[3] = scoreTest.Min(x => x.Test4);

            foreach (var item in ave)
            {
                Console.Write($"{item:N2}\t");
            }

            Console.WriteLine();
            foreach (var item in max)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();
            foreach (var item in min)
            {
                Console.Write($"{item}\t");
            }

        }

    }
}
