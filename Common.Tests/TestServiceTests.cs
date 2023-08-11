using Shouldly;

namespace Common.Tests
{
    public class TestServiceTests
    {
        [Fact]
        public void GetName()
        {
            TestService testService = new TestService();
            var result = testService.GetName();
            result.ShouldBe(string.Empty);
        }
    }
}