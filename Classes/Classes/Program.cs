using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Make = "Nissan";
            c1.Model = "Teana";
            c1.Rego = "LDM366";
            c1.Colour = "Silver";
            Console.WriteLine($"Make: {c1.Make}\nModel: {c1.Model}\nRego: {c1.Rego}\nColour: {c1.Colour}");
            Car c2 = new Car();
            c2.Make = "Toyota";
            c2.Model = "Hilux";
            c2.Rego = "ABC123";
            c2.Colour = "Black";
            Console.WriteLine($"Make: {c2.Make}\nModel: {c2.Model}\nRego: {c2.Rego}\nColour: {c2.Colour}");





        }
    }
    class Car
    {
        string make;
        string model;
        string rego;
        string colour;
        public string Make

        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Rego
        {
            get { return rego; }
            set { rego = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

    }
}
    


