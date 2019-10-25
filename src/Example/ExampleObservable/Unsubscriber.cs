using System;
using System.Collections.Generic;

namespace Example.ExampleObservable
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<Location>>_observers;
        private IObserver<Location> _observer;
        public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
        {
            _observers = observers;
            _observer = observer;
        } 
        public void Dispose()
        {
            if(_observer == null || !_observers.Contains(_observer)) return;
            _observers.Remove(_observer);                                                                
        }
    }        
}