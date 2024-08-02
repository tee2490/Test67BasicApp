
namespace TestApp2
{
    public class GenerateData
    {
        public List<Student> StudentList { get; set; }

        public GenerateData()
        {
            StudentList = new List<Student>(); //obj
        }

        public void Create(int studentNumber = 10, int subjectNumber = 3)
        {
            Random r = new Random();

            for (int i = 1; i <= studentNumber; i++)
            {

                //จำนวนวิชาทั่งหมด กล่องที่ 2
                var subjectList = new List<Subject>();
                for (int j = 1; j <= subjectNumber; j++)
                {
                    subjectList.Add(new Subject
                    {
                        SubjectID = j,
                        Score = new Test  //กล่องที่ 3
                        {
                            Test1 = r.Next(1, 51),
                            Test2 = r.Next(1, 51),
                            Test3 = r.Next(1, 51)
                        }
                    });
                }

                //นักศึกษาทั้งหมด กล่องที่ 1
                StudentList.Add(new Student
                {
                    StudentID = i,
                    StudentSubject = subjectList //กล่องที่ 2
                });
            }
        }


        public void Display()
        {
        }

    }
}
