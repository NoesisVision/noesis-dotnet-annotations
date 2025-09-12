using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Interface |
                AttributeTargets.Struct |
                AttributeTargets.Enum |
                AttributeTargets.Delegate |
                AttributeTargets.Method)]
public class ExternalSystemIntegrationAttribute(string externalSystemName, string? name = null)
    : Attribute
{
    public string ExternalSystemName { get; } = externalSystemName;
    public string? Name { get; } = name;
}