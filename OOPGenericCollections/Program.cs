namespace OOPGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seperationLines = "-----------------------";

            List<Employee> employees = [
                new Employee("Gustav", Gender.Male, 40000),
                new Employee("Eva", Gender.Female, 40000),
                new Employee("Liam", Gender.Male, 30000),
                new Employee("Anna", Gender.Female, 30000),
                new Employee("Hugo", Gender.Male, 20000)
            ];

            var stack = new Stack<Employee>();
            PushEmployeesToStack(employees, stack);

            foreach (Employee employee in stack)
            {
                employee.DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(seperationLines);

            Console.WriteLine("Retrive Using Pop Method");
            while (stack.Count > 0)
            {
                stack.Pop().DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(seperationLines);

            PushEmployeesToStack(employees, stack);

            Console.WriteLine("Retrive Using Peek Method");

            for (int i = 0; i < 2; i++)
            {
                stack.Peek().DisplayEmployeeInfo();
                DisplayItemsLeftInStack(stack);
            }

            Console.WriteLine(seperationLines);
            // employees[2] is the third employee because its zero based
            if (stack.Contains(employees[2]))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }

        }

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
