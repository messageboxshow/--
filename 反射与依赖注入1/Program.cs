using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 反射与依赖注入1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new HeavyTank();
            //========华丽的分割线===============//

            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");  //好像要知道具体的方法名称 
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(o,null);
            runMi.Invoke(o,null);



        }
    }
    class Driver
    {
        private Ivehicle _ivehicle;

        public Driver(Ivehicle ivehicle)
        {
            _ivehicle = ivehicle;
        }

        public void Drive()
        {
            _ivehicle.Run();
        }



    }


    interface Ivehicle
    {
        void Run();


    }

    class Car : Ivehicle
    {


        public void Run()
        {
            Console.WriteLine("car  is running....");
        }
    }

    class Truck : Ivehicle
    {

        public void Run()
        {
            Console.WriteLine("truck  is running...");
        }
    }

    interface Ifire
    {
        void Fire();
    }
    interface ITank : Ivehicle, Ifire
    {
        void Run();
    }


    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("BOOM");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka Ka");
        }
    }

    class MediuTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("BOOM!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka Ka!!!");
        }
    }


    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("BOOM!!!!!!!!!!!!!!!!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka Ka Ka!!!!!!!!!!!!!!");
        }
    }
}
