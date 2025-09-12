using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Method)]
public class EntryPointAttribute(string? name = null) : DomainBehaviorAttribute(name)
{
    public string? Process { get; init; }
    public TriggeredBy TriggeredBy { get; init; }
}