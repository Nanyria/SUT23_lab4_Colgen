using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_lab4_Colgen
{
    internal class ListEx
    {
        static List<Employee> EmpList = Employee._empList;
        static Employee em1;
        static Employee em2;
        static Employee em3;
        static Employee em4;
        static Employee em5;

        /// <summary>
        /// Går kanske att lägga denna på ett ställe så att den bara behöver deklareras
        ///en gång istället för flera?
        /// </summary>
        static public void EmpInfo()
        {
            em1 = new Employee(001, "Lars", "Male", 22000);
            em2 = new Employee(002, "Mia", "Female", 33000);
            em3 = new Employee(003, "Kim", "Non-Binary", 30000);
            em4 = new Employee(004, "Allan", "Male", 27000);
            em5 = new Employee(005, "Jasmine", "Female", 25000);

        }
        static public void AddEm()
        {
            EmpList.Add(em1);
            EmpList.Add(em2);
            EmpList.Add(em3);
            EmpList.Add(em4);
            EmpList.Add(em5);
        }
        static public void Check()
        {
            AddEm();
            if (EmpList.Contains(em2))
            {
                Console.WriteLine("Employee2 object exist in the list.");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list.");
            }

        }
        static public void FindEm()
        {
            EmpInfo();
            AddEm();
            Employee item = EmpList.Find(e => e._gender == "Male");
            Console.WriteLine($"First male in list:\nID-number: {item._id}" +
                    $"\nName: {item._name}" +
                    $"\nGender: {item._gender}" +
                    $"\nSalary: {item._salary}\n");

            Console.WriteLine("All male employees in list:");
            List<Employee> allMales = EmpList.FindAll(e => e._gender == "Male");
            foreach (Employee male in allMales)
            {
                Console.WriteLine($"ID-number: {male._id}" +
                  $"\nName: {male._name}" +
                  $"\nGender: {male._gender}" +
                  $"\nSalary: {male._salary}\n");

            }

        }

    }
}
