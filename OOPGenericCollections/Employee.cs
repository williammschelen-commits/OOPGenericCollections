namespace OOPGenericCollections
{
    internal class Employee
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public Gender Gender { get; init; }
        public decimal Salary { get; private set; }
        public Employee(int id, string name, Gender gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            Id = id;
        }

        public void DisplayEmployeeInfo() => Console.WriteLine($"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}");
    }
}
