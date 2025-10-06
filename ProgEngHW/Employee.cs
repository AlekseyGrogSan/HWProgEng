using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgEngHW
{
    public class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int Salary { get; private set; }
        public string Position { get; private set; } = string.Empty;
        public Employee(int id, string name, int salary, string position)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Position = position;
        }

        public void UpdateSalary(int salary)
        {
            if (salary < 0)
                throw new ArgumentException("Salary cannot be negative");
            Salary = salary;
        }
        public void UpdatePosition(string position)
        {
            if (string.IsNullOrEmpty(position))
                throw new ArgumentException("Position cannot be empty");
            Position = position;
        }
    }
}
