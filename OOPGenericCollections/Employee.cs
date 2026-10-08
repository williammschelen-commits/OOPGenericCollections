using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGenericCollections
{
    internal class Employee
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public Gender Gender { get; init; }
        public decimal Salary { get; private set; }
        public Employee(string name, Gender gender, decimal salary)
        {
            Id = Guid.NewGuid();
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
