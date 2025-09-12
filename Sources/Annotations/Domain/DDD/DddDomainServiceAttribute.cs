using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddDomainServiceAttribute(string? name = null) : DomainObjectAttribute(name);