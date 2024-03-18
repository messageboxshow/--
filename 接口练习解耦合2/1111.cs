using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习解耦合2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fan = new DeskFan(new PowerSupply());
            Console.WriteLine(fan.Work());
        }



    }

   public interface IPowerSupply
    {
        int GetPower();
    }


   public  class PowerSupply:IPowerSupply        //面向过程的设计方法   
    {
        public int GetPower()
        {
            return 110;
        }
    }

  public   class DeskFan
    {

        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply power)
        {
            _powerSupply = power;
        }

        public string Work()
        {
            int power = _powerSupply.GetPower();
            if (power <= 0)
            {
                return "动不起来啊";
            }
            else if(power<100)
            {
                return "电流不够";
            }else if(power<200)
            {
                return "勉强能用";
            }else
            {
                return "坏了";
            }

        }

    }

}
