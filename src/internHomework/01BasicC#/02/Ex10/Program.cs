
struct Employee
{
    public string FirstName;
    public string LastName;
    public byte Age;
    public char Gender;
    public long PersonalID;
    public int EmployeeNumber;
}

class Program
{

    static void Main(string[] args)
    {
        Employee employee1 = new Employee();
        employee1.FirstName = "Alexandar";
        employee1.LastName = "Tashkov";
        employee1.Age = 20;
        employee1.Gender = 'm';
        employee1.PersonalID = 8306112507L;
        employee1.EmployeeNumber = 27569999;
        Console.WriteLine("\nEmployee information: \n");
        Console.WriteLine($"First name: {employee1.FirstName}\nLast name: {employee1.LastName}\nAge: {employee1.Age}\n" +
            $"Gender: {employee1.Gender}\nPersonalID: {employee1.PersonalID}\nEmployee number: {employee1.EmployeeNumber}");
    }
}