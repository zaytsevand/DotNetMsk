using System;
using Microsoft.Owin.Hosting;

namespace DotNetMsk._10.DemoTestProject.Host
{
    public class OwinHostService : IService, IDisposable
    {
        private readonly string _baseAddress;
        private IDisposable _app;

        public OwinHostService(OwinHostServiceConfig config)
        {
            _baseAddress = config.BaseAddress;
        }

        public void Dispose()
        {
            _app?.Dispose();
        }

        public bool Start()
        {
            _app = WebApp.Start<Startup>(_baseAddress);
            return true;
        }

        public bool Stop()
        {
            return true;
        }
    }
}