using System;

namespace DotNetMsk._10.DemoTestProject.Contracts
{
    public class TimePassedRequest
    {
        public DateTime ClientTime { get; }

        public TimePassedRequest(DateTime clientTime)
        {
            ClientTime = clientTime;
        }

        public TimePassedRequest TillNow() => new TimePassedRequest(DateTime.UtcNow);
    }
}
