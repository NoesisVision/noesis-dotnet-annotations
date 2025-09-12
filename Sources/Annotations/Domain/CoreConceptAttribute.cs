using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Interface |
                AttributeTargets.Struct |
                AttributeTargets.Enum |
                AttributeTargets.Delegate |
                AttributeTargets.Method)]
public class CoreConceptAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}