using System;

namespace initialOop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myVehicle = new Vehicle();
        }

        public class Vehicle
        {
            int MaxNumPassengers;
            string Color;
            double MaxSpeed;

            void MakeNoise(string noise)
            {
                Console.WriteLine(noise);
            }

            void MakeNoise()
            {
                Console.WriteLine("Vroom!");
            }

            // Somevehicle.ColorProp => Color
            // SomeVehicle.ColorProp = "Some Color"
            string ColorProp
            {
                get
                {
                    return Color;
                }
                set
                {
                    Color = value;
                }
            }
        }
    }
}