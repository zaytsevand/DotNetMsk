using System;
using HttpMock;

namespace DotNetMsk._10.DemoTestProject.UnitTests
{
    public static class HttpMockServer
    {
        public static IHttpServer LaunchTimeStub(string baseAddress)
        {
            var result = new HttpServer(new Uri(baseAddress));

            throw new NotImplementedException();
            //TODO: setup stub

            return result;
        }
    }
}