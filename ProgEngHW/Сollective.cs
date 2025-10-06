using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgEngHW
{
    public class Сollective
    {
        private List<Employee> employees;
        public Сollective()
        {
            employees = new List<Employee>();
        }

        public Сollective(params Employee[] emps)
        {
            employees = new List<Employee>();
            foreach (var emp in emps)
                employees.Add(emp);
        }
        public void AddEmployee(Employee employee)
        {
            if (employees.Any(e => e.Id == employee.Id))
                throw new ArgumentException("Employee with the same ID already exists");
            employees.Add(employee);
        }
        public void RemoveEmployee(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                throw new ArgumentException("Employee not found");
            employees.Remove(employee);
        }
        public void EditEmployee(int id, int? salary = null, string? position = null)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                throw new ArgumentException("Employee not found");
            if (salary.HasValue)
                employee.UpdateSalary(salary.Value);
            if (!string.IsNullOrEmpty(position))
                employee.UpdatePosition(position);
        }
        public void GetAllEmployees()
        {
            foreach (var emp in employees)
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Position: {emp.Position}");
        }
    }
}
