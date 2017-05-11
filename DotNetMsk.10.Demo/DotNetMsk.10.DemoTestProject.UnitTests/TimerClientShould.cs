using System;
using System.Threading.Tasks;
using DotNetMsk._10.DemoTestProject.Tests.Shared;
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

        [Severity(Severity.Blocker)]
        [TestCase("2017-01-01", ExpectedResult = "")]
        [TestCase("1970-01-01T00:00:00.0000000Z", ExpectedResult = "00:00:00")]
        [TestCase("1970-01-01T00:00:00.0000001Z", ExpectedResult = "00:00:00.0000001")]
        [TestCase("1969-12-31T23:59:59.9999999Z", ExpectedResult = "-00:00:00.0000001")]

        [TestCase("9999-12-31T20:59:59.9999999Z", ExpectedResult = "2932896.17:59:59.9999999")]

        [TestCase("0001-01-01T00:00:00.0000000Z", ExpectedResult = "-719162.03:00:00")]
        public Task CalculateTimestampFromStartOfUnixEpoch(string tillDate)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _httpMock?.Dispose();
        }
    }
}
