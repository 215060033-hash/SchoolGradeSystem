using System;

namespace SchoolGradeSystem
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== OKUL OTOMASYONU BASLATILIYOR ===");

            SchoolManager manager = new SchoolManager();

            // 1. Veri Girisi
            manager.AddStudent(201, "Burak Yilmaz");
            manager.AddStudent(202, "Ahmet Demir");

            manager.AddCourse("SWE203", "Software Construction", 4);
            manager.AddCourse("MAT101", "Calculus I", 5);

            Console.WriteLine("\n--- ISLEMLER ---");

            // 2. Not Verme
            manager.AssignGrade(201, "SWE203", 85);
            manager.AssignGrade(201, "MAT101", 90);

            // 3. Hata Testi (Validation kontrolü)
            manager.AssignGrade(202, "MAT101", 150);

            // 4. Rapor
            manager.PrintReport();

            Console.ReadLine(); // Konsol hemen kapanmasın diye
        }
    }
}
