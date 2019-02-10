using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    class Univercity
    {
        public List<Student> students;
        public List<Student> hostel;

        public Univercity()
        {
            students = new List<Student>();
            hostel = new List<Student>();

            Student[] newStudents =
            {
                new Student("Oleg", "Sergeevich", Gender.Man, "Экономист", 4.75, Study.fullTime, 150000),
                new Student("Anna", "Alexandrovna",  Gender.Woman, "Программное обеспечение", 5.0, Study.correspondence, 60000),
                new Student("Maxim", "Semenov", Gender.Man, "Электро-техническ.", 3.99, Study.fullTime, 850000),
            };

            foreach (var student in newStudents)
                students.Add(student);
        }

        public void HostelForming()
        {
            double minimalSalary = 40000;

            foreach (var student in students)
            {
                if (student.Salary < minimalSalary)
                {
                    hostel.Add(student);
                }
            }
            students.Sort(ScoreComparer);

            foreach (var student in students)
            {

                if (student.Salary >= minimalSalary)
                {
                    hostel.Add(student);
                }
            }

            int index = 1;
            foreach (var student in hostel)
            {
                Console.Write(index + ")"); index++;
                student.ShowInfo();
            }
        }

        private int ScoreComparer(Student student1, Student student2)
        {
            if (student1.AverageScore > student2.AverageScore) return -1;
            else if (student1.AverageScore < student2.AverageScore) return 1;

            return 0;
        }

    }
}
