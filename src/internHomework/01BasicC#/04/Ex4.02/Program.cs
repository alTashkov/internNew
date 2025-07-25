class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Enter fax number: ");
        string? faxNumber = Console.ReadLine()!;
        faxNumber = string.IsNullOrWhiteSpace(faxNumber) ? null : faxNumber;

        Console.Write("Enter website: ");
        string website = Console.ReadLine();

        Console.Write("Enter manager's first name: ");
        string managerFname = Console.ReadLine();

        Console.Write("Enter manager's last name: ");
        string managerLname = Console.ReadLine();

        Console.Write("Enter manager's age: ");
        string managerAge = Console.ReadLine();

        Console.Write("Enter manager's phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine($"\n{companyName} information");
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"\nCompany name: {companyName}\nCompany address: {companyAddress}\nPhone number: {phoneNumber}");
        Console.Write((faxNumber != null) ? $"Fax number: {faxNumber}" : "Fax number: (no fax)");
        Console.WriteLine($"\nWebsite: {website}\nManager first name: {managerFname}\nManager last name: {managerLname}\n" +
            $"Manager age: {managerAge}\nManager phone: {managerPhone}");
    }
}