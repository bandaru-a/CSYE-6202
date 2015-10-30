﻿using System;

namespace FootPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarbonFootprint[] list = new ICarbonFootprint[3];

            list[0] = new Bicycle();
            list[1] = new Building(2500);
            list[2] = new Car(10);

            for (int i = 0; i < list.Length; i++)
            Console.WriteLine(list[i].GetCarbonFootprint());
            Console.ReadLine();
        }

        public class Bicycle : ICarbonFootprint
        {
            public string Make { get; set; }
            public string Model { get; set; }

            public int GetCarbonFootprint()
            {
                return 0;
            }
        }

        public class Building : ICarbonFootprint
        {
            private int squareFootage;
            public Building(int squareFootage)
            {
                this.squareFootage = squareFootage;
            }

            public string Address { get; set; }

            public int GetCarbonFootprint()
            {
                return 50 * squareFootage;
            }
        }

        public class Car : ICarbonFootprint
        {
            private int gasGallons;
            public Car(int gasGallons)
            {
                this.gasGallons = gasGallons;
            }

            public string Make { get; set; }
            public string Model { get; set; }

            public int GetCarbonFootprint()
            {
                return 20 * gasGallons;
            }
        }

        public interface ICarbonFootprint
        {
            int GetCarbonFootprint();
        }
    }
}
