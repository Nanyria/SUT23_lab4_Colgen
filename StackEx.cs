using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_lab4_Colgen
{
    internal class Stack
    {
        static Stack<Employee> Employees = Employee.EmplSt;
        static Employee em1;
        static Employee em2;
        static Employee em3;
        static Employee em4;
        static Employee em5;

        static public void EmpInfo()
        {
            em1 = new Employee(001, "Lars", "Male", 22000);
            em2 = new Employee(002, "Mia", "Female", 33000);
            em3 = new Employee(003, "Kim", "Non-Binary", 30000);
            em4 = new Employee(004, "Allan", "Male", 27000);
            em5 = new Employee(005, "Jasmine", "Female", 25000);

        }
        static public void PushEm()
        {
            Employees.Push(em1);
            Employees.Push(em2);
            Employees.Push(em3);
            Employees.Push(em4);
            Employees.Push(em5);
        }
        static public void PrintStack()
        {
            PushEm();
            Stack<Employee> Employees = Employee.EmplSt;
            int count = Employees.Count();

            foreach (Employee e in Employees)
            {
                Console.WriteLine($"ID-number: {e._id}" +
                    $"\nName: {e._name}" +
                    $"\nGender: {e._gender}" +
                    $"\nSalary: {e._salary}" +
                    $"\nItems left in stack: {count}\n");
            }
        }
        static public void PopStack()
        {
            PushEm();
            int count = Employees.Count();

            for (int i = 0; i < count; i++)
            {
                int count2 = Employees.Count();
                Employee empop = Employees.Pop();
                Console.WriteLine($"ID-number: {empop._id}" +
                    $"\nName: {empop._name}" +
                    $"\nGender: {empop._gender}" +
                    $"\nSalary: {empop._salary}" +
                    $"\nItems left in stack: {count2 - 1}\n");
            }
        }
        static public void Peek()
        {
            PushEm();
            int count = Employees.Count();
            Employee peekEm = Employees.Peek();

            Console.WriteLine($"ID-number: {peekEm._id}" +
               $"\nName: {peekEm._name}" +
               $"\nGender: {peekEm._gender}" +
               $"\nSalary: {peekEm._salary}" +
               $"\nItems left in stack: {count - 1}\n");
            Console.WriteLine($"ID-number: {peekEm._id}" +
               $"\nName: {peekEm._name}" +
               $"\nGender: {peekEm._gender}" +
               $"\nSalary: {peekEm._salary}" +
               $"\nItems left in stack: {count - 1}\n");

        }
        static public void Check()
        {
            PushEm();
            if (Employees.Contains(em3))
            {
                Console.WriteLine("Employee E3 is in the list.");
            }
            else
            {
                Console.WriteLine("Employee E3 is not in the list.");
            }

        }

    }

}

