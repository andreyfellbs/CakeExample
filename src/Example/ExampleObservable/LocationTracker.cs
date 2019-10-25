using System;
using System.Collections.Generic;

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
            if(!observers.Contains(observer))
                observers.Add(observer);
                          
            return new Unsubscriber(observers, observer);
        }

        public void TrackLocation(Location? location)
        {
            bool locationHasValue = location.HasValue;

            observers.ForEach(o => {
                if(locationHasValue)
                    o.OnNext(location.Value);
                else
                    o.OnError(new LocationUnknownException());
            });
        }

        public void EndTransmission()
        {
            observers.ForEach(o =>  o.OnCompleted());

            observers.Clear();
        }
    }
}