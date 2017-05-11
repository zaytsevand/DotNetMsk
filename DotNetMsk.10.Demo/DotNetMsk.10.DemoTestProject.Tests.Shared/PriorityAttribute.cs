using NUnit.Framework;

namespace DotNetMsk._10.DemoTestProject.Tests.Shared
{
    public class PriorityAttribute : PropertyAttribute
    {
        public PriorityAttribute(Priority severity) : base(severity) { }
    }
}