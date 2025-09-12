using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class LayerAttribute(string name) : Attribute, NamespaceApplicable
{
    public string Name { get; } = name;
    public bool ApplyOnNamespace { get; init; }
}