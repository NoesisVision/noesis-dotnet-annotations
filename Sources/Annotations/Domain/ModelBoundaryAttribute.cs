using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class ModelBoundaryAttribute(string? name = null) : Attribute, NamespaceApplicable, DomainPerspectiveAttribute
{
    public string? Name { get; } = name;

    public bool ApplyOnNamespace { get; init; }
}