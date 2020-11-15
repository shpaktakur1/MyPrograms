using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class BankTerminal
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect() // метод Connect (базовый класс)
        {
            Console.WriteLine("General Connecting Protocol...");//"подключение к серверу"
        }
    }

    public class ModelXTerminal : BankTerminal
    {
        public ModelXTerminal(string id) : base(id) 
        { 
        }
        public override void Connect() // override - переопределить
        {
            base.Connect();
            Console.WriteLine("Additional actions for Model X");
        }
    }

    public class ModelYTerminal : BankTerminal
    {
        public ModelYTerminal(string id) : base(id)
        {
        }
        public override void Connect() // override - переопределить
        {
            Console.WriteLine("Additional actions for Model Y");
        }
    }
}
