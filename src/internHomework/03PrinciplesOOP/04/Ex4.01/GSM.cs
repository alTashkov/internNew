using Ex4._01;

public class GSM
{
    private string model;

    private string manufacturer;

    private double? price;

    private string owner;

    private Battery battery;

    private Display display;

    private List<Call> callHistory = new List<Call>();

    private static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 1500.00, new Display(5, 160000));

    public string Manufacturer
    {
        get { return manufacturer; }
    }

    public double? Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    public Battery Battery
    {
        get { return battery; }
        set { battery = value; }
    }

    public Display Display
    {
        get { return display; }
        set { display = value; }
    }

    public GSM() { }
    public GSM(string model, string manufacturer2) 
    {
        this.model = model;
        manufacturer = manufacturer2;
    }

    public GSM(string model, string manufacturer, double price)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
    }

    public GSM(string model, string manufacturer, double price, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.display = display;
    }

    public GSM(string model, string manufacturer, double price, double displaySize, Battery battery)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.battery = battery;
    }
    public GSM(string model, string manufacturer, double price, double displaySize, Battery battery, Display display)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.Price = price;
        this.battery = battery;
        this.display = display;
    }

    public static GSM IPhone4S
    {
        get { return iPhone4S; }
    }

    public List<Call> CallHistory
    {
        get { return callHistory; }
    }

    public void PrintGSM()
    {
        Console.WriteLine("GSM:\n" + $"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price} lv." +
            $"\nDisplay size: {display.Size} inch");
    }

    public override string ToString()
    {
        return "GSM:\n" + $"Model: {model}\nManufacturer: {manufacturer}\nPrice: {price} lv." +
            $"\nDisplay size: {display.Size} inch"); ;
    }

    public void AddCall(Call call)
    {
        callHistory.Add(call);
    }

    public void DeleteCall(Call call)
    {
        callHistory.Remove(call);
    }

    public void ClearCalls()
    {
        callHistory.Clear();
    }

    public void PrintCallHistory()
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            Call call = callHistory[i];

            Console.WriteLine(call.ToString());
            Console.WriteLine();
        }
    }
}
