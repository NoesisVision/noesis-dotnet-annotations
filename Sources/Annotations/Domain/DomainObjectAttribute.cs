using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Interface |
                AttributeTargets.Struct |
                AttributeTargets.Enum |
                AttributeTargets.Delegate |
                AttributeTargets.Method)]
public class DomainObjectAttribute(string? name = null) : Attribute
{
    public string? Name { get; } = name;
}