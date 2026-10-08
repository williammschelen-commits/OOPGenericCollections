namespace OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string separationLines = "-----------------------";

            // Create a list of employees so i can easily loop through them
            List<Employee> employees = [
                new Employee(101, "Gustav", Gender.Male, 40000),
                new Employee(102, "Eva", Gender.Female, 40000),
                new Employee(103, "Liam", Gender.Male, 30000),
                new Employee(104, "Anna", Gender.Female, 30000),
                new Employee(105, "Hugo", Gender.Male, 20000)
            ];

            var stack = new Stack<Employee>();
            PushEmployeesToStack(employees, stack);

            foreach (Employee employee in stack)
            {
                employee.DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(separationLines);

            Console.WriteLine("Retrieve Using Pop Method");
            while (stack.Count > 0)
            {
                stack.Pop().DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(separationLines);

            PushEmployeesToStack(employees, stack);

            Console.WriteLine("Retrieve Using Peek Method");

            for (int i = 0; i < 2; i++)
            {
                stack.Peek().DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(separationLines);
            // employees[2] is the third employee because its zero based
            if (stack.Contains(employees[2]))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

            Console.WriteLine(separationLines);

            if (employees.Contains(employees[1]))
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list");
            }

            Console.WriteLine(separationLines);

            // Finds the first male employee
            Employee? maleEmployee = employees.Find(e => e.Gender == Gender.Male);
            maleEmployee?.DisplayEmployeeInfo();

            Console.WriteLine(separationLines);

            // Creates a new list of all male employees
            List<Employee> maleEmployees = employees.FindAll(e => e.Gender == Gender.Male);

            foreach (Employee employee in maleEmployees)
            {
                employee.DisplayEmployeeInfo();
            }


        }

        // A method for pushing employees to stack to avoid needing to repeat the same foreach loop more than once
        private static void PushEmployeesToStack(List<Employee> employees, Stack<Employee> stack)
        {
            foreach (Employee employee in employees)
            {
                stack.Push(employee);
            }
        }

        private static void DisplayItemsLeftInStack(Stack<Employee> stack)
        {
            Console.WriteLine($"Items left in the stack = {stack.Count}");
        }
    }
}
