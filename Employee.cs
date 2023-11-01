using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Collection_generics
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public Employee(int Id, string Name, string Gender, int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;
    
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salary}";
        }
    }
}
