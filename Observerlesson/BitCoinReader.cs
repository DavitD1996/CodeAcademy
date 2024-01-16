using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Observerlesson
{
    internal class BitCoinReader
    {
        private double _value;
        public double Value { get { return _value; } }
        public delegate void MyDelegate(double data);
        public event EventHandler<EventArgs> myAttepmt;
        public event MyDelegate notifyAll;
        public void updateValue()
        {
            _value= new Random().NextDouble();
            priceChanged();
        }
        private void priceChanged()
        {
            notifyAll.Invoke(_value);
            myAttepmt.Invoke(this,new EventArgs());
        }
    }
}
