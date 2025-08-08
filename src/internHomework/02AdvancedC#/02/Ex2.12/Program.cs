class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter website url: ");
        string url = Console.ReadLine();

        int protocolIndex = url.IndexOf("://");
        string protocol = url.Substring(0,protocolIndex);

        string urlNoProtocol = url.Substring(protocolIndex+3);

        int resourceIndex = urlNoProtocol.IndexOf("/");
        string resource = urlNoProtocol.Substring(resourceIndex);

        string server = urlNoProtocol.Substring(0,resourceIndex);

        Console.WriteLine($"[protocol] = {protocol}\n[server] = {server}\n[resource] = {resource}");

    }
}