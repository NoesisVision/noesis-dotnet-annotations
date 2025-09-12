using JetBrains.Annotations;

namespace Noesis.P3.Annotations;

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