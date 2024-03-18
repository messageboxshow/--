using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类的虚方法
{

    //使用override声明方法与使用new声明方法
    //base 用法 显示调用父类的构造函数
    //this 用法 构成构造函数的重载====使用 this 关键字来调用其他构造函数的语法是在构造函数内部使用的，并且必须是构造函数的第一个语句

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my.HashTable();



            Swoth swoth = new Swoth();
            MyClass my1 = (MyClass)swoth;
            //SonClss son = new SonClss();
            //MyClass my2 = (MyClass)son;
            //my2.HashTable();
            //son.HashTable();
            swoth.HashTable();
            my1.HashTable();
            
            //Student student=new Student()   构造函数重载


            Console.ReadKey();
        }
    }
    class MyClass
    {
        virtual public void HashTable()
        {
            Console.WriteLine( "我是虚方法");
        }       

    }

    class SonClss:MyClass
    {
        public override void HashTable()
        {
            Console.WriteLine( "我是重写后的方法");
        }

    }

    class Swoth:SonClss
    {
        public override void HashTable()      //    <=======这里关键字换成new后，调用不到override
        {
            Console.WriteLine( "我是第二个儿子里的方法");
        }

    }


    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }


        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public void Kang()
        {
            Console.WriteLine("名字是{0},{1},{2}", this.Name, this.Age, this.Gender);
        }

    }


    public class Hushi : Person
    {
        public double Money
        {
            get;
            set;
        }

        public Hushi(string name, int age, char gender, double money)
            : base(name, age, gender)    
        {
            this.Money = money;
        }


        public void Langfa()
        {
            Console.WriteLine("我的名字{0}，{1}，{2}，{3}", this.Name, this.Age, this.Gender, this.Money);

        }

    }



    public class Student
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int ID
        {
            get;
            set;
        }

        public double X
        {
            get;
            set;
        }


        public Student(string name, int age, char gender, int id)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.ID = id;
        }

        public Student(string name, int age, char gender) : this(name, age, gender, 0)//使用 this 关键字来调用其他构造函数的语法是在构造函数内部使用的，并且必须是构造函数的第一个语句
        {

        }


        public Student(int age, char gender, int id,double x) : this(null, age, gender, id)
        {
            this.X = x;
        }

        public Student(char gender):this(null ,0,gender,0)
        {


        }
           
        
    }
}
