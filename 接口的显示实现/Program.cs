using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口的显示实现
{
    class Program
    {
        static void Main(string[] args)
        {

            var wk = new WarmKiller();
            wk.Kill();    //这里不想被调用杀手这个能力   显示实现接口这里就调用不到kill
            wk.Kill(50);    //这里不想被调用杀手这个能力   显示实现接口这里就调用不到kill
            wk.Love();
            //IKiller killer = new WarmKiller();  //这样调用隐藏起来的能力
            IKiller killer = wk;
            killer.Kill();




            var wk1 = killer as WarmKiller;   //强制类型转换
            wk1.Love();
            Console.ReadKey();
        }
    }

    interface IGentleman
    {
        void Love();
    }
    interface IKiller
    {
        void Kill();
    }


    class WarmKiller : IGentleman,IKiller
    {
        

        public void Love()
        {
            Console.WriteLine("我爱你...");
        }


        public void Kill()
        {
            Console.WriteLine("让我来杀两个人练练胆...");
        }

         void IKiller.Kill()
        {
            Console.WriteLine("让我来杀BAS个人练练胆...");
        }

        public void Kill( int a)
        {
            Console.WriteLine($"让我来杀{a}个人练练胆...");
        }
    }
}
