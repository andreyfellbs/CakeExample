using System;

public class StatusReportOptions
{
    public DateTime reportPurgeTs { get; set; }
    public ReportMail reportMail { get; set; }
    public HttpStatusPush httpStatusPush { get; set; }
}