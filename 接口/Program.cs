using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new NewCar();
            vehicle.Fly();

        }
    }

    #region      接口怎么演化而来
    abstract class Vehicle
    {
        public abstract void Eat();
        public abstract void Drink();
        public abstract void Run();
        public abstract void Fly();
    }

    class Car : Vehicle                  //当一个非抽象类继承一个纯抽象类后，必须实现纯抽象类中所有的方法体

    {
        public override void Eat()
        {
            Console.WriteLine("我是第一个继承里面的吃");
        }

        public override void Drink()
        {
            Console.WriteLine("我是第一个继承里的喝");
        }

        public override void Run()
        {
            Console.WriteLine("我是第一个继承里的跑");
        }

        public override void Fly()
        {
            Console.WriteLine("我是第一个继承里的飞");
        }
    }

    class NewCar : Car            //当一个正常类继承下来后，可以利用关键字override 重写他父类的方法 并且可以被最上层的纯抽象类进行里氏转换
    {
        public override void Fly()
        {
            Console.WriteLine("我是第二个继承里的飞");
        }

        public override void Run()
        {
            Console.WriteLine("我是第二个继承里的跑");
        }
    }
    #endregion










    interface IVehicl                       //纯抽象类就是接口 ，关键字interface  接口要求内部成员都是public的
    {                                     //接口一定就是纯抽象的 所以不能写abstract
        void Eat();
        void Drink();
        void Run();
        void Fly();
    }

    abstract class Ca : IVehicl                           //<===========这里加abstract是为了不完全实现fly接口    留给下一级实现 

    {
        public void Eat()
        {
            Console.WriteLine("我是第一个继承里面的吃");
        }

        public void Drink()
        {
            Console.WriteLine("我是第一个继承里的喝");
        }

        abstract public void Run();            //在这个抽象类里，部分的实现一般的接口

        abstract public void Fly();

    }

    class NewCa : Ca
    {
        public override void Fly()
        {
            Console.WriteLine("我是第二个继承里的飞");
        }

        public override void Run()
        {
            Console.WriteLine("我是第二个继承里的跑");
        }
    }







}


