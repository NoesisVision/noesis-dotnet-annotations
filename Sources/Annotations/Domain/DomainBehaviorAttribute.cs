using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Method |
                AttributeTargets.Delegate |
                AttributeTargets.Interface)]
public class DomainBehaviorAttribute(string? name = null) : Attribute
{
    public string? Name { get; } = name;
}