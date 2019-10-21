using System.Collections.Generic;

public class Recipient
    {
        public string number { get; set; }
        public IList<string> alternativeNumbers { get; set; }
        public IList<Property> properties { get; set; }
    }