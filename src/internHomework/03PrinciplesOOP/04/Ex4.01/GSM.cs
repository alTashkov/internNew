using Ex4._01;

class GSM
{
    private string Model { get; set; }
    private string Manufacturer { get; init; }
    double Price { get; set; }
    string? Owner { get; }

    private Battery battery;
    private Display display;

    private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 1500.00, new Display(5,160000));

    private List<Call> callHistory = new List<Call>();

    public GSM() { }
    public GSM(string model, string manufacturer) 
    {
        this.Model= model;
        this.Manufacturer = manufacturer;
    }

    public GSM(string model, string manufacturer, double price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
    }

    public GSM(string model, string manufacturer, double price, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.display = display;
    }

    public GSM(string model, string manufacturer, double price, double displaySize, Battery battery)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.battery = battery;
    }
    public GSM(string model, string manufacturer, double price, double displaySize, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Price = price;
        this.battery = battery;
        this.display = display;
    }
    public Battery Battery
    {
        get { return this.Battery; }
    }

    public Display Display
    {
        get { return this.Display; }
    }

    public static GSM IPhone4S
    {
        get { return iPhone4S; }
    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
    }

    public void PrintGSM()
    {
        Console.WriteLine("GSM:\n" + $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price} lv." +
            $"\nDisplay size: {this.display.Size} inch");
    }

    public override string ToString()
    {
        return "GSM:\n" + $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price} lv." +
            $"\nDisplay size: {this.display.Size} inch";
    }

    public void AddCall(Call call)
    {
        this.callHistory.Add(call);
    }

    public void DeleteCall(Call call)
    {
        this.callHistory.Remove(call);
    }

    public void ClearCalls()
    {
        this.callHistory.Clear();
    }

    public void PrintCallHistory()
    {
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            Call call = this.callHistory[i];

            Console.WriteLine(call.ToString());
            Console.WriteLine();
        }
    }
}
