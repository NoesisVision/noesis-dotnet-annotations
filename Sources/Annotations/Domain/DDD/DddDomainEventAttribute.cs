using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddDomainEventAttribute(string? name = null) : DomainBuildingBlockAttribute(name);