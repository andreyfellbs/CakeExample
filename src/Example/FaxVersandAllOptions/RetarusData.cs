using System.Collections.Generic;

public class RetarusData
    {
        public Reference reference { get; set; }
        public IList<Recipient> recipients { get; set; }
        public IList<Document> documents { get; set; }
        public TransportOptions transportOptions { get; set; }
        public RenderingOptions renderingOptions { get; set; }
        public StatusReportOptions statusReportOptions { get; set; }
        public Meta meta { get; set; }
    }