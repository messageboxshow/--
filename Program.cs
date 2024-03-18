using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的继承

{
    //类的继承是
    //类在功能上的拓展
    //只能有一个基类，但可以实现多个接口
    //类的访问级别对继承有影响
    //sealed密封类不能被继承
    class Program
    {
        static void Main(string[] args)
        {
            OtherClass other = new OtherClass();
            other.PrintField1();


            SonClass son = new SonClass();
            MyClass my = (MyClass)son;   //将子类转换成父类
            my.Print();                 //父类调用自己的print
            son.Print();                //子类调用自己的print
                                       //父类无法拿到子类的成员
            Console.ReadKey();
        }
    }








    //一个子类的实例从语意来说也是父类的实例
    //子类的访问级别不能超越父类的访问级别
    //继承的本质是派生类在基类已有的成员基础上完整的继承基类成员，对基类进行了横向或者纵向上的拓展//除了构造函数
    //横向拓展指的是对类成员个数的扩充
    //纵向拓展指的是对类成员的重写overrid
    class SomeClass
    {
        public string Field1 = "我来自基类";


    }
    class OtherClass : SomeClass
    {

        public new string Field1 = "我来自派生类"; // 使用关键字new来隐藏父类同名字段与方法
        public void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);        //使用关键字base可以调用隐藏起来的父类字段
        }

    }







    class MyClass
    {
        public void Print()
        {
            Console.WriteLine("我是基类");
        }


    }
    class SonClass : MyClass
    {
        //public int Value;
        new public void Print()
        {
            Console.WriteLine("这是派生类");
        }
    }


}
