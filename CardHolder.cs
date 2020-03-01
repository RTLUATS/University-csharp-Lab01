using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Lab01
{

    internal class CardHolder
    {
        [Name("Id")]
        public  int id { get; set; }
        
        [Name("Name")]
        public string holder { get; set; }

        internal int _money { get; set; }


        CardHolder()
        {
           
        }

        internal void Update(int value)
        {
            _money = value;
        }


        internal void Event(string message)
        {
            Console.WriteLine("____________________________\n\n"+
                             $"{holder}\t{message}" +
                              "\n__________________________\n");
        } 

        public override string ToString() => string.Format($"{holder}\t\t{_money}");
    }
}
