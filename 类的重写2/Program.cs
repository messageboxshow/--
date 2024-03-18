using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的重写2
{
    class Program
    {
        /// <summary>
        /// 虚方法重载 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Son son = new Son();
            Car car = new Car();
            Vehicle vehicle = (Vehicle)son;//car   哪个子类装进父类。父类就调用谁的成员
            //Vehicle vehicle = new Vehicle();
            vehicle.Run();
            Console.WriteLine(vehicle.Speed);
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        private int _speed;

        public virtual int Speed
        {
            get
            {
                return _speed;
            }
            set
            {

                _speed = value;
            }
        }
        public virtual void Run()
        {
            Console.WriteLine("我是父类的方法");
            _speed = 100;
        }

    }

    class Car : Vehicle
    {
        private int _rpm;

        public override int Speed
        {
            get
            {
                return _rpm / 1000;

            }
            set
            {
                _rpm = value;

            }
        }
        public override void Run()
        {
            Console.WriteLine("我是大儿子中的方法");
            _rpm = 10000;
        }
    }




    class Son : Car
    {
        private int _RIT;
        public override int Speed
        {
            get
            {
                return _RIT / 5;
            }
            set
            {
                _RIT = value;
            }
        }
        public override void Run()
        {
            Console.WriteLine("我是大孙子中的方法");
            _RIT = 30000;
        }
    }


}
