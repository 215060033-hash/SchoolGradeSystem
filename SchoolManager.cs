using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolGradeSystem
{
    public class SchoolManager
    {
        private List<Student> students = new List<Student>();
        private List<Course> courses = new List<Course>();
        private List<GradeEntry> grades = new List<GradeEntry>();

        public void AddStudent(int no, string name)
        {
            students.Add(new Student(no, name));
            Console.WriteLine($"+ Ogrenci Eklendi: {name} ({no})");
        }

        public void AddCourse(string code, string name, int credit)
        {
            courses.Add(new Course(code, name, credit));
            Console.WriteLine($"+ Ders Eklendi: {name} ({code})");
        }

        public void AssignGrade(int studentNo, string courseCode, int gradeVal)
        {
            var student = students.FirstOrDefault(s => s.StudentNo == studentNo);
            var course = courses.FirstOrDefault(c => c.CourseCode == courseCode);

            if (student == null || course == null)
            {
                Console.WriteLine("! HATA: Ogrenci veya Ders bulunamadi. Islem iptal.");
                return;
            }

            GradeEntry entry = new GradeEntry(studentNo, courseCode);
            entry.Grade = gradeVal;

            grades.Add(entry);
            Console.WriteLine($"> Not Girisi: {student.FullName} -> {course.CourseName}: {entry.Grade}");
        }

        public void PrintReport()
        {
            Console.WriteLine("\n--- DONEM SONU RAPORU ---");
            foreach (var entry in grades)
            {
                var stName = students.First(s => s.StudentNo == entry.StudentNo).FullName;
                var crName = courses.First(c => c.CourseCode == entry.CourseCode).CourseName;

                Console.WriteLine($"Ogrenci: {stName} | Ders: {crName} | Not: {entry.Grade}");
            }
            Console.WriteLine("-------------------------");
        }
    }
}
