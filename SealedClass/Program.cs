using System;

namespace SealedClass
{
    interface IEmployee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods
        public string Fullname();
        public double Pay();
    }

    class Employee : IEmployee
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructors
        public Employee()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Methods
        public string Fullname()
        {
            return FirstName + " " + LastName;
        }

        public virtual double Pay()
        {
            double salary;
            Console.WriteLine($"What is {this.Fullname()}'s weekly salary?");
            salary = double.Parse(Console.ReadLine());
            return salary;
        }
    }

    sealed class Executive : Employee
    {
        // Fields
        public string Title { get; set; }
        public double Salary { get; set; }

        // Constructors
        public Executive() : base()
        {
            Title = string.Empty;
            Salary = 0;
        }

        public Executive(int id, string firstName, string lastName, string title, double salary)
            : base(id, firstName, lastName)
        {
            Title = title;
            Salary = salary;
        }

        // Override Pay method
        public override double Pay()
        {
            return Salary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an employee object
            Employee employee = new Employee(1, "Jeff", "Bezos");
            Console.WriteLine($"Employee: {employee.Fullname()}, Weekly Salary: {employee.Pay()}");

            // Create an executive object
            Executive executive = new Executive(2, "Jane", "Smith", "CEO", 10000);
            Console.WriteLine($"Executive: {executive.Fullname()}, Title: {executive.Title}, Weekly Salary: {executive.Pay()}");
        }
    }
}