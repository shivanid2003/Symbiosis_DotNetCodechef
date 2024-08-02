using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vehicle
    {
	
        public string Make { get; set; }
        public string Model { get; set; }

        // Common method to show vehicle details
        public virtual void Show()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
        }

        // Common method to display vehicle details
        public virtual void Display()
        {
            Show();
        }
    }
}
internal class FourWheeler : Vehicle
{
    public int NumberOfWheels { get; set; } = 4;

    // Override Show method to include four-wheeler details
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
    }
}
internal class TwoWheeler : Vehicle
{
    public int NumberOfWheels { get; set; } = 2;

    // Override Show method to include two-wheeler details
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
    }
}
internal class Car : FourWheeler
{
    public string CarType { get; set; }

    // Override Show method to include car details
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Car Type: {CarType}");
    }
}


    internal class SUV : Car
    {
        public bool IsOffRoad { get; set; }

        // Override Show method to include SUV details
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Is Off-Road: {IsOffRoad}");
        }
    }
	public static void Main(string [] args)
	{
		SUV mySUV = new SUV
		{
   		 Make = "Toyota",
   		Model = "Land Cruiser",
   		CarType = "Luxury",
    		IsOffRoad = true
		};

		Console.WriteLine("SUV Details:");
		mySUV.Display(); 
	}

