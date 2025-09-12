using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly)]
public class DeployableUnitAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}