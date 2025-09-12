using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class)]
public class SkipNamespaceInDomainModulesHierarchyAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}