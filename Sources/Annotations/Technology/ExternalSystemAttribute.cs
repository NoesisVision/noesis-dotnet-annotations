using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Method)]
public class ExternalSystemAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}