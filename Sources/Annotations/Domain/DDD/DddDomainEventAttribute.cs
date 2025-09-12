using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddDomainEventAttribute(string? name = null) : DomainObjectAttribute(name);