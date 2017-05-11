using NUnit.Framework;

namespace DotNetMsk._10.DemoTestProject.Tests.Shared
{
    public class SeverityAttribute : PropertyAttribute
    {
        public SeverityAttribute(Severity severity) : base(severity) { }
    }
}
