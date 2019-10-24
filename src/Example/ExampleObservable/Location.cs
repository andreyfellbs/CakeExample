namespace Example.ExampleObservable
{
    public struct Location
    {
        double lat, lon;

        public Location(double latitude, double longitude)
        {
            lat = latitude;
            lon = longitude;
        }

        public double Latitude => lat;

        public double Longitude => lon;
    }
}