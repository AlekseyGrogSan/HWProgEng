namespace ProgEngHW
{
    public class Program
    {
        //Программа для работы с персоналом
        //Возможности:
        //1. Добавление нового сотрудника
        //2. Удаление сотрудника
        //3. Редактирование данных сотрудника
        //4. Просмотр списка всех сотрудников
        static void Main(string[] args)
        {
            Сollective collective = new Сollective();
            while (true)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Edit Employee");
                Console.WriteLine("4. View All Employees");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter ID: ");
                            int id = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Enter Name: ");
                            string name = Console.ReadLine() ?? string.Empty;
                            Console.Write("Enter Salary: ");
                            int salary = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Enter Position: ");
                            string position = Console.ReadLine() ?? string.Empty;
                            collective.AddEmployee(new Employee(id, name, salary, position));
                            break;
                        case "2":
                            Console.Write("Enter ID of employee to remove: ");
                            int removeId = int.Parse(Console.ReadLine() ?? "0");
                            collective.RemoveEmployee(removeId);
                            break;
                        case "3":
                            Console.Write("Enter ID of employee to edit: ");
                            int editId = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("Enter new Salary (or leave empty): ");
                            string salaryInput = Console.ReadLine() ?? string.Empty;
                            int? newSalary = string.IsNullOrEmpty(salaryInput) ? null : int.Parse(salaryInput);
                            Console.Write("Enter new Position (or leave empty): ");
                            string newPosition = Console.ReadLine() ?? string.Empty;
                            collective.EditEmployee(editId, newSalary, newPosition);
                            break;
                        case "4":
                            collective.GetAllEmployees();
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine();
            }
        }
    }
}
