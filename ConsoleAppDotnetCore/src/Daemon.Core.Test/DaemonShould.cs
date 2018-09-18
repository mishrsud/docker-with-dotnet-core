using System;
using Xunit;

namespace Daemon.Core.Test
{
    public class DaemonShould
    {
        [Fact]
        public void Print_Hello_World()
        {
            Assert.Equal("Hello world!", "Hello world!");
        }
    }
}
