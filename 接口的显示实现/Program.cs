using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口的显示实现
{
    class Program
    {
        ///
        ///
        ///这个限制使得其他类成员不能直接访问显示接口成员实现，派生类的成员也不得直接访问他们。他们必须总是通过接口的引用来访问
        ///
        /// 
        /// 
        /// 
        /// 


        static void Main(string[] args)
        {
            WarmKiller w = new WarmKiller();   //这里调用不到显示实现的接口
            w.Kill();
            IKiller ki = w as IKiller;       //强制转换当前对象的引用为接口类型，才能掉到显示接口的方法
            ki.Kill();
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

    class WarmKiller : IGentleman, IKiller
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
            Console.WriteLine("让我来杀10000个人练练胆...");
        }


    }
}
