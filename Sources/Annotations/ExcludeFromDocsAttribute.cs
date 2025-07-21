using JetBrains.Annotations;

namespace Noesis.P3.Annotations;

[PublicAPI]
[AttributeUsage(AttributeTargets.All)]
public class ExcludeFromDocsAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}
