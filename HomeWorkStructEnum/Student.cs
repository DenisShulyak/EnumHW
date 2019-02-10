using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    class Student
    {
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public Gender gender { get; private set; }

        public string Group { get; private set; }
        public double AverageScore { get; private set; }
        public Study Study { get; private set; }

        public double Salary { get; set; }

        public Student(string name, string surName,
            Gender gender, string group, double averageScore, Study study, double salary)
        {
            Name = name;
            SurName = surName;
            this.gender = gender;

            Group = group;
            AverageScore = averageScore;
            Study = study;

            Salary = salary;
        }

        public void ShowInfo()
        {
           

            Console.WriteLine($"Имя Фамилия: {Name} {SurName}");
            Console.WriteLine($"Пол: {gender}");
            Console.WriteLine($"Зарплата: {Salary} тг");
            Console.WriteLine($"Группа: {Group}");
            Console.WriteLine($"Средний балл: {AverageScore}");
            Console.WriteLine($"Вид обучения: {Study}");
        }

    }
}
