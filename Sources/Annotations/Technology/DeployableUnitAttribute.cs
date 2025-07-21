using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly)]
public class DeployableUnitAttribute : Attribute
{
    public string Name { get; }

    public DeployableUnitAttribute(string name) => Name = name;
}