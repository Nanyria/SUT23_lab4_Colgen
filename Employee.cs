using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_lab4_Colgen
{
    internal class Employee
    {
        public static Stack<Employee> EmplSt = new Stack<Employee>();
        public static List<Employee> _empList = new List<Employee>();  
        
        public int _id { get; set; }
        public string _name { get; set; }
        public string _gender { get; set; }
        public double _salary { get; set; }

        public Employee(int id, string name, string gender, double salary)
        {
            _id = id;
            _name = name;
            _gender = gender;
            _salary = salary;
        }
    }
}
