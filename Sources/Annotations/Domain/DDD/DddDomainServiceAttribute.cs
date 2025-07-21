using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddDomainServiceAttribute(string? name = null) : DomainBuildingBlockAttribute(name);