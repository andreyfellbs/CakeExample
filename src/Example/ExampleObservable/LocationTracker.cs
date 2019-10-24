using System;
using System.Collections.Generic;
using System.Linq;

namespace Example.ExampleObservable
{
    public class LocationTracker : IObservable<Location>
    {
        private List<IObserver<Location>> observers;
        
        public LocationTracker()
        {
            observers = new List<IObserver<Location>>();
        }

        public IDisposable Subscribe(IObserver<Location> observer)
        {
            observers.Any(o => o.GetHashCode() == observer.GetHashCode())
        }
    }
}