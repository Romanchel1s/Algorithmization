using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public class Car
    {
        public string Name;
        public int Id;
        public Car(string name,  int id)
        {
            Name = name;
            Id = id;
        }
    }
    public class Driver
    {
        public string FIO;
        public int CarId;
        public Driver(string fio, int id)
        {
            FIO = fio;
            CarId = id;  
        }
    }
    class MainProgram
    {
        public static void Main()
        {
            Car lada = new Car("Lada", 1);
            Driver vova = new Driver("Vov4ik", 1);
            List <Driver> Drivers = new List<Driver>();
            List <Car> Cars = new List<Car>();
            Drivers.Add(vova);
            Cars.Add(lada);
            var DC = from p in Drivers
                     where p.FIO[0] == 'V'
                     select p;
            foreach (Driver driver in Drivers)
            {
                var id = driver.CarId;
                Console.WriteLine(driver.FIO);
                var c = from p in Cars
                        where p.Id == id
                        select p;
                foreach (Car car in c)
                {
                    Console.WriteLine(car.Name);
                }
            }
        }
    }
}
