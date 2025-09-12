using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Delegate |
                AttributeTargets.Method |
                AttributeTargets.Field |
                AttributeTargets.Property)]
public class ScenarioAttribute(string? name = null) : Attribute
{
    public string? Name { get; } = name;
}