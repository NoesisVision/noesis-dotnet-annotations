using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
public enum TriggeredBy
{
    Unspecified,
    Command,
    Query,
    Event
}