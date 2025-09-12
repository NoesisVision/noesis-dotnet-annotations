using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ProcessAttribute(string name) : Attribute, NamespaceApplicable
{
    public string Name { get; } = name;
    public bool ApplyOnNamespace { get; init; }
}