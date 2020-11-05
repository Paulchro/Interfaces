using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           // AutoMobile auto = new AutoMobile();

            Console.WriteLine("car c");
            Car c = new Car(true);
            c.SteerLeft();

            Console.WriteLine("car car");
            Car car = new Car();
            Console.WriteLine(car.IsOn); // default 0
            car.Start();
            car.SteerLeft();

            Console.WriteLine(car.IsOn);

            //car.IsON = false;
            
            car.Stop();
            Console.WriteLine(car.IsOn);

            Console.WriteLine("Motorbike moto");
            Motorbike moto = new Motorbike();
            moto.Start();
            moto.SteerLeft();
            Console.WriteLine(moto.IsOn);

            Console.WriteLine("Moto2");
            Motorbike moto2 = new Motorbike(true);
            moto2.Start();
            Console.WriteLine(moto2.IsOn);
            moto2.SteerLeft();
            moto2.Stop();
            Console.WriteLine(moto2.IsOn);

            car.Left();
            Console.WriteLine("Car steering left");
            car.Right();
            Console.WriteLine("Car steering right");


            Boat boat = new Boat();
            boat.Left();
            Console.WriteLine("boat steering left");
            boat.Right();
            Console.WriteLine("Boat steering right");
           
            moto.Left();
            Console.WriteLine("Moto steering left");
            moto.Right();
            Console.WriteLine("Moto steering right");
        }
    }
}
