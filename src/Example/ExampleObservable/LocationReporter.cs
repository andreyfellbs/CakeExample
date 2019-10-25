using System;

namespace Example.ExampleObservable
{
    public class LocationReporter : IObserver<Location>
    {
        private string instName;
        private IDisposable unsubscriber;
        
        public string Name => instName; 

        public LocationReporter(string name)
        {
            instName = name;
        }

        public void OnCompleted()
        {
            Console.WriteLine("The Location Tracker has completed transmitting data to {0}.", Name);
            Unsubscribe();                        
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The location cannot be determined.", Name);
        }

        public void OnNext(Location value)
        {
            Console.WriteLine("{2}: The current location is {0}, {1}", value.Latitude, value.Longitude, this.Name);
        }
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}