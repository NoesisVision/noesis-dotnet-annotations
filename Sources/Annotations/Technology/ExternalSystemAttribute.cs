using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ExternalSystemAttribute(string? name = null) : Attribute
{
    public string? Name { get; } = name;
}