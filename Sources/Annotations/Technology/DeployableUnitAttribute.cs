using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly)]
public class DeployableUnitAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}