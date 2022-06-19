



using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;





//namespace Csharp_lesson5
//{

//    class Worker
//    {

//        public int Id { get; set; }
//        public string Name { get; set; }

//        public Worker()
//        {
//            Console.WriteLine(" default constructor");
//        }

//        public Worker(int id, string name)
//        {
//            Id = id;
//            Name = name;
//        }


//        static Worker()
//        {
//            Console.WriteLine(" static constructor");
//            Console.WriteLine();
//        }


//    }


//    class Car
//    {

//        public static DateTime GlobalStartTime;

//        static Car()
//        {
//            GlobalStartTime = DateTime.Now;
//            Console.WriteLine($@" static constructor called.
//            Global StartTime --> {GlobalStartTime.ToLongTimeString()}");
//        }

//        public Car(int id)
//        {
//            Thread.Sleep(1000);
//            Id = id;
//        }

//        public int Id { get; set; }
//        public void Drive()
//        {
//            Console.WriteLine();
//            TimeSpan elapsed_time = DateTime.Now - GlobalStartTime;
//            Console.WriteLine($@" car id --> {Id} 
//            is starting its works {elapsed_time.Seconds} seconds after
//            global start time {GlobalStartTime.ToLongTimeString()}");
//        }


//    }





//    public class Program
//    {

   

//        public static object MessageBox { get; private set; }

//        static void Main()
//        {

//            //Worker[] workers = new Worker[3];

//            //for (int i = 0; i < workers.Length; i++)
//            //{

//            //    workers[i] = new Worker();

//            //}


//            //for (int i = 0; i < 10; i++)
//            //{
//            //    Car car = new Car(1);
//            //    Thread.Sleep(350);
//            //    car.Drive();
//            //}


//            // partial (definition ve generation)

//            //BankAccount bankAccount = new BankAccount()
//            //{
//            //    Id = 1, Name = "John"
//            //};


//            //////////////////////////////////////////////////

//            //////////////////////////////////////////////////

//            //////////////////////////////////////////////////

//            //Console.WriteLine();
//            //BankAccount bankAccount = new BankAccount("mike");
//            //Console.WriteLine();


//            // Console.WriteLine(NetWorkConstants.TempFolderPath);


//            string tempPath = System.IO.Path.GetTempPath();
//            //public static readonly string DefaultLogFilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);










//        }

//    }

//}








// ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------





namespace Game
{

    class Miner
    {

        public string  Fullname { get; set; }
        public double Salary { get; set; }
        public int Energy { get; set; } = 100;
        public decimal Income { get; set; }
        public Manager Manager { get; set; } = null;

        public void DrinkRedBull()
        {
            Energy += 50;
        }

        public void Work()
        {
            if(Energy >0)
            {
                Energy -= 5;
                Income += 5;
            }
        }


    }

    class Manager
    {

        public string Name { get; set; }
        public int Energy { get; set; }
        public decimal Income_percent { get; set; }
        public decimal Energy_percent { get; set; }



    }

    public class Program
    {

        static void Main(string[] args)
        {

        }

    }

}

