using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace Lab01
{
    public delegate void Handler(int _money);

    public delegate void HandlerEvent(string message );

    class Card // наблюдаемый обьект
    {
        private Handler handler;
        
        private event HandlerEvent handlerEvent;
        
        [Name("Id")]
        public int id { set; get; }
        
        [Name("Money")]
        public int _money { set;get;}



        Card()
        {
            
        }


        public void SetMoney(int value)
        {

            if (_money + value >= 0)
            {
                EventNotify(value*(-1));
                _money += value;
                Notify(_money);
            }

        }

        internal void AddObserver(Handler nameHandler)
        {
            handler += nameHandler;
        }

        internal void AddEvent(HandlerEvent handler)
        {
            handlerEvent += handler;
        }

        internal void RemoveObserver(Handler nameHandler)
        {
            handler -= nameHandler;
        }

        internal void RemoveEvent(HandlerEvent handler)
        {
            handlerEvent -= handler;
        }

        internal void Notify(int value)
        {
            handler?.Invoke(value);
        }

        internal void EventNotify(int value)
        {
            
            handlerEvent?.Invoke($"Withdraw { value}");

        }

    }
}
