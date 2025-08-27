using Ex4._01;

public class GSM
{

    private string manufacturer;
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public double Price { get; set; }
    public string Owner { get; }

    private Battery battery;
    private Display display;

    private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 1500.00, new Display(5,160000));

    private List<Call> callHistory = new List<Call>();
    public GSM() { }
    public GSM(string model, string manufacturer2) 
    {
        Model = model;
        manufacturer = manufacturer2;
    }

    public GSM(string model, string manufacturer, double price)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
    }

    public GSM(string model, string manufacturer, double price, Display display)
    {
        Model = model;
        Manufacturer = manufacturer;
        Price = price;
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
        get { return battery; }
        set {  battery = value; }
    }

    public Display Display
    {
        get { return display; }
        set { display = value; }
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
