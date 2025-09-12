using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class DomainModelAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}