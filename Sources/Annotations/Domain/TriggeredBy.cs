using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
public enum TriggeredBy
{
    Unspecified,
    Command,
    Query,
    Event
}