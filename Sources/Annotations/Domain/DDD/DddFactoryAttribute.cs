using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddFactoryAttribute(string? name = null) : DomainObjectAttribute(name);