namespace lab_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Faculty and Staff
            Faculty faculty = new Faculty("John Doe", "123-456-7890", "johndoe@example.com", "Computer Science", 80000, new DateTime(2018, 5, 1), "9 AM - 5 PM", "Senior Lecturer");
            Staff staff = new Staff("Jane Smith", "987-654-3210", "janesmith@example.com", "Administration", 50000, new DateTime(2020, 3, 15), "Manager");

            // Display Faculty details
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"Bonus: {faculty.CalculateBonus():C}");
            Console.WriteLine($"Vacation Weeks: {faculty.CalculateVacation()} weeks");

            Console.WriteLine();

            // Display Staff details
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"Bonus: {staff.CalculateBonus():C}");
            Console.WriteLine($"Vacation Weeks: {staff.CalculateVacation()} weeks");
        }
    }
}
