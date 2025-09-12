using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class)]
public class SkipNamespaceInDomainModulesHierarchyAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}