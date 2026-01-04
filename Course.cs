namespace SchoolGradeSystem
{
    public class Course
    {
        public string CourseCode { get; init; }
        public string CourseName { get; set; }
        public int Credit { get; set; }

        public Course(string courseCode, string courseName, int credit)
        {
            CourseCode = courseCode;
            CourseName = courseName;
            Credit = credit;
        }
    }
}
