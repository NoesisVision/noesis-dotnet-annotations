using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly)]
public class TierAttribute : Attribute
{
    public string Name { get; }

    public TierAttribute(string name) => Name = name;
}