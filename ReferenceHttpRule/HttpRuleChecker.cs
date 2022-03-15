using Google.Api;
using Google.Protobuf.Reflection;

namespace ReferenceHttpRule
{
    public static class HttpRuleChecker
    {
        public static bool HasHttpRule(MethodDescriptor methodDescriptor)
        {
            var options = methodDescriptor.GetOptions();
            var http = options?.GetExtension(AnnotationsExtensions.Http);

            return http != null;
        }
    }
}