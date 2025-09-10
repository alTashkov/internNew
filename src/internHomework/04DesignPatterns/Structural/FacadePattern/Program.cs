namespace FacadePattern
{
    internal class Program
    {
        //Facade organizes/encapsulates interfaces/classes into a
        //single class/interface as to ease the client
        //It makes it easier to read and maintain 
        static void Main(string[] args)
        {
            CarFacade car = new CarFacade();
            car.StartCar();
        }
    }
}
