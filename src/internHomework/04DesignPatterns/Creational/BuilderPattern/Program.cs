using System;

namespace BuilderPattern
{
    internal class Program
    {
        //Builder lets you create objects step by step
       //Useful when youo have many optional parts or 
       //complex setup -> flexible
        static void Main(string[] args)
        {
            ICarBuilder builder = new CarBuilder();

            builder.SetEngine("V8");
            builder.SetWheels(4);
            builder.SetGPS("Yes");
            builder.SetSunroof(true);

            Car sportsCar = builder.Build();
            Console.WriteLine(sportsCar);
            Console.ReadLine();
        }
    }
}
