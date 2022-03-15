using Greet;
using ReferenceHttpRule;
using Xunit;

namespace ProtobufExtensionBug
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var methodDescriptor = Greeter.Descriptor.FindMethodByName("SayHello");
            var hasHttRule = HttpRuleChecker.HasHttpRule(methodDescriptor);
            Assert.True(hasHttRule);
        }
    }
}