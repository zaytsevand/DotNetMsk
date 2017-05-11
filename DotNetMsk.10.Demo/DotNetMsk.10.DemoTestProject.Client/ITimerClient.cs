using System;
using System.Threading.Tasks;

namespace DotNetMsk._10.DemoTestProject.Client
{
    public interface ITimerClient
    {
        Task<TimeSpan> GetTimePassedTillDateAsync(DateTime dateTime);
        Task<TimeSpan> GetTimePassedTillDate(DateTime dateTime);
        Task<TimeSpan> GetTimePassedTillNowAsync();
        Task<TimeSpan> GetTimePassedTillNow();
    }
}
