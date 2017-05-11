using System;
using HttpMock;
using NUnit.Framework;

namespace DotNetMsk._10.DemoTestProject.UnitTests
{
    [TestFixture]
    public class TimerClientShould : IDisposable
    {
        private readonly IHttpServer _httpMock;

        public TimerClientShould()
        {
            _httpMock = HttpMockServer.LaunchTimeStub("http://localhost:10001/api/time");
        }

        public void Dispose()
        {
            _httpMock?.Dispose();
        }
    }
}
