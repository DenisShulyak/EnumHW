using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkStructEnum
{
    class Office
    {
        private Worker[] employers;

        public Office()
        {
            employers = new Worker[] {
                new Worker("Ivan", "Ivanov", 3, 500000, new int[] { 4, 04, 1989 }), 
                new Worker("Olga", "Sergeevna", 0, 70000, new int[] { 9, 02, 2015 }),
                new Worker("Johnny", "Depp", 2, 275000, new int[] { 24, 02, 2006 }),
                new Worker("Sergey", "Shevchenco", 1, 150000, new int[] { 14, 09, 2019 }),

            };
        }

        public void ShowAllWorkers()
        {
            foreach (var worker in employers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }
        
        public void FindManagers()
        {
            List<Worker> managers = new List<Worker>();
            int clerkCount = 0;
            double clerkSalarySum = 0;
            double averageClerkSalary = 0;

            foreach (var worker in employers)
            {
                if (worker.position == Position.director)
                {
                    clerkSalarySum += worker.Salary;
                    clerkCount++;
                }
            }
            averageClerkSalary = clerkSalarySum / clerkCount;

            foreach (var worker in employers)
            {
                if (worker.position == Position.Manager && worker.Salary > averageClerkSalary)
                    managers.Add(worker);
            }

            managers.Sort(SurnameSort);

            foreach (var worker in managers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }

      //Cортировка по фамилиям сотрудников
        private int SurnameSort(Worker worker1, Worker worker2)
        {
            return (worker1.SurName.CompareTo(worker2.SurName));
        }
        //Сотрудники принятые позже босса
        public void PrintAllAfterChef()
        {
            List<Worker> workers = new List<Worker>();

            Worker boss = new Worker();

            foreach (var worker in employers)
                if (worker.position == Position.Chef) boss = worker;

            foreach (var worker in employers)
                if (CompareDates(worker, boss)) workers.Add(worker);

            workers.Sort(SurnameSort);
            foreach (var worker in workers)
            {
                worker.InfoAboutEmployees();
                Console.WriteLine();
            }
        }
        // Сравнение дат
        private bool CompareDates(Worker worker1, Worker worker2)
        {
            if (worker1._Date[2] > worker2._Date[2])
            {
                return true;
            }
            else if (worker1._Date[2] < worker2._Date[2])
            {

                return false;
            }
            else if (worker1._Date[2] == worker2._Date[2])
            {

                if (worker1._Date[1] > worker2._Date[1])
                {

                    return true;
                }
                else if (worker1._Date[1] < worker2._Date[1])
                {

                    return false;
                }
                else if (worker1._Date[1] == worker2._Date[1])
                {

                    if (worker1._Date[0] > worker2._Date[0])
                    {

                        return true;
                    }
                    else if (worker1._Date[0] < worker2._Date[0])
                    {

                        return false;
                    }
                    else if (worker1._Date[0] == worker2._Date[0])
                    {

                        return false;
                    }
                }
            }
            return false;
        }

    }
}
