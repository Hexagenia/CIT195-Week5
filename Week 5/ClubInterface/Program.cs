using System;

namespace LateModelStockCarTeam
{
    interface ITeamMember
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Methods
        public string Fullname();
    }

    class TeamMember : ITeamMember
    {
        // Fields
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public int CarNumber { get; set; }

        // Parameterized Constructor
        public TeamMember(int id, string firstName, string lastName, string role, int carNumber)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            CarNumber = carNumber;
        }

        // Default Constructor
        public TeamMember()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Role = string.Empty;
            CarNumber = 0;
        }

        // Method to display team member information
        public void DisplayTeamMemberInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Fullname()}");
            Console.WriteLine($"Role: {Role}");
            Console.WriteLine($"Car Number: {CarNumber}");
        }

        // Method to display full name
        public string Fullname()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* Creating a team member object using the parameterized constructor
            I went with Cliff Daniels because that's Larson's CC in NASCAR. #6 because when Larson races dirt late models, he's 6 instead of 5.
             */
            TeamMember crewChief = new TeamMember(1, "Cliff", "Daniels", "Crew Chief", 6);
            crewChief.DisplayTeamMemberInfo();
            Console.WriteLine();

            // Creating another team member object using the default constructor
            TeamMember driver = new TeamMember();
            driver.Id = 2;
            driver.FirstName = "Kyle";
            driver.LastName = "Larson";
            driver.Role = "Driver";
            driver.CarNumber = 6;
            driver.DisplayTeamMemberInfo();
        }
    }
}