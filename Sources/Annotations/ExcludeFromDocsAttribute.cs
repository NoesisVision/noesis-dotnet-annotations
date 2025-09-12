using JetBrains.Annotations;

namespace NoesisVision.Annotations;

[PublicAPI]
[AttributeUsage(AttributeTargets.All)]
public class ExcludeFromDocsAttribute : Attribute, NamespaceApplicable
{
    public bool ApplyOnNamespace { get; init; }
}
