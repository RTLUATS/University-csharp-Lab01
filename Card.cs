using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01
{
    public delegate void Handler(int _money);

    public delegate void HandlerEvent(int value);

    class Card // наблюдаемый обьект
    {
        private Handler handler;
        
        private event HandlerEvent handlerEvent;

        internal int id { set; get; }
        
        internal int _money {
            set
            {
                if (_money - value < 0)
                {
                    EventNotify(0);   
                }
                else if(value < 0)
                {
                    EventNotify(value);
                    _money += value;
                    Notify(_money);
                }
                else
                {
                    _money = value;
                    Notify(_money);
                }
            }
            get => _money;
        }

        Card()
        {
            id = -1;
            _money = 0;
        }

        Card(int id, int amountOfFunds)
        {
            this.id = id;
            _money = amountOfFunds;
        }

        internal void AddObserver(Handler nameHandler)
        {
            handler += nameHandler;
        }

        internal void AddEvent(HandlerEvent handler)
        {
            handlerEvent -= handler;
        }

        internal void RemoveObserver(Handler nameHandler)
        {
            handler -= nameHandler;
        }

        internal void RemoveEvent(HandlerEvent handler)
        {
            handlerEvent -= handler;
        }

        internal void Notify(int _money)
        {
            handler?.Invoke(_money);
        }

        internal void EventNotify(int value)
        {
            handlerEvent?.Invoke(value);
        }

    }
}
