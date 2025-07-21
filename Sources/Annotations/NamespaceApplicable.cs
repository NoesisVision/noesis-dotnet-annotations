using JetBrains.Annotations;

namespace Noesis.P3.Annotations;

[PublicAPI]
public interface NamespaceApplicable
{
    public bool ApplyOnNamespace { get; }
}