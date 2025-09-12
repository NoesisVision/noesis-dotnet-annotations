using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddRepositoryAttribute(string? name = null) : DomainObjectAttribute(name);