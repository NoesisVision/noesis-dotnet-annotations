using JetBrains.Annotations;

namespace Noesis.P3.Annotations.People;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class DevelopmentOwnerAttribute(string name) : Attribute, NamespaceApplicable
{
    public string Name { get; } = name;
    public bool ApplyOnNamespace { get; init; }
}