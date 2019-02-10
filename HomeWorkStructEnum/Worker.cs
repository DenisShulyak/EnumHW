using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    class Worker
    {
        public string Name { get; set; }

        public string SurName { get; set; }

        public Position position { get; set; }

        public int Salary { get; set; }

        public int[] _Date { get; set; }

        public Worker()
        {

        }

        public Worker(string name, string surName, int position, int salary, int[] Date)
        {
            Name = name;

            SurName = surName;

            this.position = (Position)position;

            Salary = salary;

            _Date = new int[3];

            for (int i = 0; i < _Date.Length; i++)
            {
                _Date[i] = Date[i];
            }
        }

        public void InfoAboutEmployees()
        {
            Console.Write($"\n{Name} {SurName}\n" + $"Должность: {position}\n" + $"Зарплата: {Salary} тг\n" + "Дата приема на работу: ");

            foreach (var number in _Date)
                Console.Write(number + " ");

            Console.WriteLine();
        }

    }
}
