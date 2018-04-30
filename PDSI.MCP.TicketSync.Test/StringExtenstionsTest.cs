using System;
using Xunit;

namespace PDSI.MCP.TicketSync.Test
{
    public class StringExtenstionsTest
    {
        [Fact]
        public void Id_Captures_Correct_Value()
        {
            Assert.Equal(-1, Extensions.Id("[hoopla]"));
            Assert.Equal(-1, Extensions.Id("[h00p1a]"));
            Assert.Equal(-1, Extensions.Id("[400p1a]"));
            Assert.Equal(100, Extensions.Id("[100]"));
            Assert.Equal(299, Extensions.Id("Provision Data Systems Inc. (PDSI) [299]"));
            Assert.Equal(299, Extensions.Id("Provision Data Systems Inc. [123] (PDSI) [299]"));
        }

        [Fact]
        public void Left_happy_path()
        {
            Assert.Null(Extensions.Left(null, 100));
            Assert.Empty(Extensions.Left("", 100));
            Assert.Equal("Provision", Extensions.Left("Provision", 9));
            Assert.Equal("Provision", Extensions.Left("Provision", 100));
            Assert.Equal("Provision", Extensions.Left("Provision Data Systems Inc.", 9));
        }
    }
}
