using JetBrains.Annotations;

namespace NoesisVision.Annotations;

[PublicAPI]
public interface NamespaceApplicable
{
    public bool ApplyOnNamespace { get; }
}