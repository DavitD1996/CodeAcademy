using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Observerlesson
{
    internal interface Iobservable<T>
    {
        void addObserver(IObserver<T> observer);
        void removeObserver(IObserver<T> observer);
        void NotifyAllObservers();
    }
}
