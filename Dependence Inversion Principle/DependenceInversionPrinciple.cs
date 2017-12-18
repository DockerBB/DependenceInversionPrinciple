using System;

namespace Yizit.DesignModel.DIP
{
    public interface IDriver
    {
         void Drive(ICar car);
        
    }
    public interface ICar
    {
        void Run();
        
    }

    public class Driver : IDriver
    {
        private string _name;
        

        public Driver()
        {

        }
        public Driver(string name)
        {
            _name = name;
        }

        public void Drive(ICar car)
        {
            
            Console.Write("{0}驾驶",_name);
            car.Run();
        }
    }

    public class BMWCar : ICar
    {
        public void Run()
        {
            Console.WriteLine("宝马车开始运行");
        }
    }

    public class BENZCar : ICar
    {
        public void Run()
        {
            Console.WriteLine("奔驰车开始运行");
        }
    }
    public class Client
    {
        public static void Main(string[] args)
        {
            ICar benz = new BENZCar();
            IDriver driver = new Driver("tom");
            driver.Drive(benz);
            Console.ReadLine();
        }
    }
}
