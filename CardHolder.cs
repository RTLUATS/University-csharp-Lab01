using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Lab01
{

    internal class CardHolder
    {

        internal  int id { get; set; }

        internal string holder { get; set; }

        internal  int _money { get; set; }


        CardHolder()
        {
            id = -1;
            holder = null;
            _money = 0;
        }

        CardHolder(int id,string holder)
        {
            this.id = id;
            this.holder = holder;
        }

        internal void Update(int value)
        {
            _money += value;
        }

        internal void Event(int value)
        {
            Console.WriteLine(value == 0 ? "insufficient funds" : $"Withdraw {value}$");
        } 

        public override string ToString() => string.Format($"{holder}\t{_money}");
    }
}
