using System.Security.Cryptography.X509Certificates;

namespace SUT23_lab4_Colgen
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            PopStack();

            Console.ReadKey();


        }
        static public void AddStack()
        {
            Employee e1 = new Employee(001, "Lars", "Male", 22000);
            Employee e2 = new Employee(002, "Mia", "Female", 33000);
            Employee e3 = new Employee(003, "Kim", "Non-Binary", 30000);
            Employee e4 = new Employee(004, "Allan", "Male", 27000);
            Employee e5 = new Employee(005, "Jasmine", "Female", 25000);

            Stack<Employee> Employees = Employee.EmplSt;

            Employees.Push(e1);
            Employees.Push(e2);
            Employees.Push(e3);
            Employees.Push(e4);
            Employees.Push(e5);
        }
        static public void PrintStack()
        {
            AddStack();
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
            AddStack();
            Stack<Employee> Employees = Employee.EmplSt;
            int count = Employees.Count();

            for (int i = 0; i < count; i++)
            {
                int count2 = Employees.Count();
                Employee empop = Employees.Pop();
                Console.WriteLine($"ID-number: {empop._id}" +
                    $"\nName: {empop._name}" +
                    $"\nGender: {empop._gender}" +
                    $"\nSalary: {empop._salary}" +
                    $"\nItems left in stack: {count2-1}\n");
                

            }
        }
    }
}