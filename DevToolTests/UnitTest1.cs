using Xunit;
using DevTool;


namespace DevToolTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Addition a = new Addition();
            Assert.Equal(1, 1);
        }
    }
}