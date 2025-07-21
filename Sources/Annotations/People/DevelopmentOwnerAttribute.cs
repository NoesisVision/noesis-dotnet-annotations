using JetBrains.Annotations;

namespace Noesis.P3.Annotations.People;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class DevelopmentOwnerAttribute : Attribute, NamespaceApplicable
{
    public string Name { get; }
    public bool ApplyOnNamespace { get; init; }

    public DevelopmentOwnerAttribute(string name) => Name = name;
}