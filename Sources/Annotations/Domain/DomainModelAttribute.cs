using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class)]
public class DomainModelAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}