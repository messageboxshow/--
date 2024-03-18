using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习解耦合
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new NokiaPhone());   //解开耦合度
            user.UsePhone();
        }

    }


    class PhoneUser
    {

        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }

        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.SendMes();
            _phone.Receive();
        }

    }


    interface IPhone
    {
        void Dail();
        void PickUp();
        void SendMes();
        void Receive();


       
    }


    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("dududu....");
        }

        public void PickUp()
        {
            Console.WriteLine("dididi....");
        }

        public void Receive()
        {
            Console.WriteLine("dadada....");
        }

        public void SendMes()
        {
            Console.WriteLine("mimimimi....");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("dududu....");
        }

        public void PickUp()
        {
            Console.WriteLine("dididi....");
        }

        public void Receive()
        {
            Console.WriteLine("dadada....");
        }

        public void SendMes()
        {
            Console.WriteLine("mimimimi....");
        }
    }
}
