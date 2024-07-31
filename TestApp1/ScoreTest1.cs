namespace TestApp1
{
    internal class Score
    {
        public int Id { get; set; }
        public List<double> Test { get; set; }

        public double sum => Test.Sum();
        public double ave => sum / Test.Count;

        static List<Score> scoreList = new List<Score>();

        public void Create(int number = 10, int test = 4)
        {
            Random random = new Random();

            //จำนวนคน
            for (int i = 0; i < number; i++)
            {
                //คะแนนสอบแต่ละครั้ง [10,20,30,40]
                var eachTest = new List<double>();
                for (int j = 0; j < test; j++)
                {
                    eachTest.Add(random.Next(1, 101));
                }

                scoreList.Add(new Score
                {
                    Id = i,
                    Test = eachTest
                });

            }

        }

        public void Display(int test=4)
        {
            Console.Write($"{"Id",-5}");
            for (int i = 1; i <= test; i++) Console.Write($"{"Test" + i,8:N2}");
            Console.Write($"{"Sum",8:N2}");
            Console.WriteLine($"{"Average",8:N2}");


            foreach (var item in scoreList)
            {
                Console.Write($"{item.Id,-5}");

                item.Test.ForEach(x => Console.Write($"{x,8:N2}"));
                Console.Write($"{item.sum,8:N2}");
                Console.WriteLine($"{item.ave,8:N2}");
            }
        }

        public void FootSummary(int test = 4)
        {

            double[] ave = new double[test];
            double[] max = new double[test];
            double[] min = new double[test];

            Console.WriteLine();
            for (int i = 0; i < test; i++)
            {
                max[i] = scoreList.Max(x => x.Test[i]); //คะแนนสอบแต่ละคร้งทั้งหมด
                Console.Write($"\t{max[i],5}");
            }
        }

    }
}
