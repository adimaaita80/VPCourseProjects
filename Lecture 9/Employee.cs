using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_9
{
    public class Employee
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Constructor
        public Employee()
        {
            
        }

        public Employee(int id, string name, DateTime dob)
        {
            Id = id;
            Name = name;
            DateOfBirth = dob;
        }

        // Methods
        public string EmployeeInfo()
        {
            return "Employee ID: " + Id.ToString() +
                "\n" + "Employee Name: " + Name +
                "\n" + "Date of Birth: " + DateOfBirth.ToShortDateString();
        }
    }
}
