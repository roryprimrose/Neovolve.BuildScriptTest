using System;
using Xunit;

namespace Neovolve.BuildScriptTest.UnitTests
{
    public class ExampleTests
    {
        [Fact]
        public void CanCreateExample()
        {
            var sut = new Example();

            var actual = sut.DoSomething();

            Assert.NotNull(actual);
        }
    }
}
