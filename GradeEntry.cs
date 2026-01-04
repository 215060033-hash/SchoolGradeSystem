using System;

namespace SchoolGradeSystem
{
    public class GradeEntry
    {
        public int StudentNo { get; init; }
        public string CourseCode { get; init; }

        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine($"[UYARI] {value} gecersiz bir nottur! Sistem bunu 0 olarak kaydetti.");
                    _grade = 0;
                }
                else
                {
                    _grade = value;
                }
            }
        }

        public GradeEntry(int studentNo, string courseCode)
        {
            StudentNo = studentNo;
            CourseCode = courseCode;
        }
    }
}
