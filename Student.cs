namespace SchoolGradeSystem
{
    public class Student
    {
        public int StudentNo { get; init; }
        public string FullName { get; set; }

        public Student(int studentNo, string fullName)
        {
            StudentNo = studentNo;
            FullName = fullName;
        }
    }
}
