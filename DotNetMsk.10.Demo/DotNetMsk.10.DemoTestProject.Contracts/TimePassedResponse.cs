using System;

namespace DotNetMsk._10.DemoTestProject.Contracts
{
    public class TimePassedResponse
    {
        public TimeSpan TimePassed { get; }

        public DateTime StartingPoint { get; set; }

        public TimePassedResponse(TimeSpan timePassed)
        {
            TimePassed = timePassed;
        }
    }
}