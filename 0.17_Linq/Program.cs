using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UsedCar> usedCars = new List<UsedCar>
            {
                new UsedCar() {VIN = "A1", Make = "Hyundai", Model = "Elantra", Price = 10000, Year = 2009},
                new UsedCar() {VIN = "A2", Make = "Honda", Model = "Accord", Price = 15000, Year = 2010},
                new UsedCar() {VIN = "A3", Make = "Chevrolet", Model = "Equinox", Price = 20000, Year = 2012},
                new UsedCar() {VIN = "A4", Make = "Toyota", Model = "Camry", Price = 25000, Year = 2015},
                new UsedCar() {VIN = "A5", Make = "Toyota", Model = "4Runner", Price = 26000, Year = 2014},
                new UsedCar() {VIN = "A6", Make = "BMW", Model = "M5", Price = 25000, Year = 2009},
                new UsedCar() {VIN = "A7", Make = "BMW", Model = "M3", Price = 13000, Year = 2009},
                new UsedCar() {VIN = "A8", Make = "Chevrolet", Model = "Impala", Price = 17000, Year = 2012}
            };

            var bmws = from car in usedCars
                       where car.Make == "BMW"
                       select car;
            foreach (var bmw in bmws)
            {
                Console.WriteLine("The {0} {1} costs {2:C}.", bmw.Year, bmw.Model, bmw.Price);
                
            }
            Console.WriteLine("*********************");
            var price = from car in usedCars
                        where car.Price < 20000
                        select car;
            foreach(var p in price)
            {
                Console.WriteLine("These cars cost less than $10000: {0} {1} {2:C}.", p.Year, p.Model, p.Price);
            }

            Console.WriteLine("*************************");
            Console.WriteLine("LINQ with Lambda");
            var toyotas = usedCars.Where(car => car.Make == "Toyota");
            foreach(var toyota in toyotas)
            {
                Console.WriteLine(toyota.Model);
            }
            var niceUsedCars = usedCars.Where(car => car.Price > 20000 && car.Make == "Ford" || car.Make == "BMW");
            foreach (var niceUsedCar in niceUsedCars)
            {
                Console.WriteLine(niceUsedCar.Model + " " + niceUsedCar.VIN);
            }





            Console.ReadLine();
        }
        class UsedCar
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }

        }
    }
}
