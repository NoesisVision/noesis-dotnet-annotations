using JetBrains.Annotations;

namespace NoesisVision.Annotations;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Interface |
                AttributeTargets.Struct |
                AttributeTargets.Enum |
                AttributeTargets.Delegate |
                AttributeTargets.Method)]
public class ExemplaryAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}