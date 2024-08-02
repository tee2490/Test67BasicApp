namespace TestApp2
{
   
    public class Test
    {
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public double Test3 { get; set; }

        public double Sum => Test1+Test2+Test3;
        public double Net => Sum * 100 / 150;
    }


    public class Subject
    {
        public int SubjectID { get; set; }
        public Test Score { get; set; }
    }


    public class Student
    {
        public int StudentID { get; set; }
        public List<Subject> StudentSubject { get; set; }
    }

}



