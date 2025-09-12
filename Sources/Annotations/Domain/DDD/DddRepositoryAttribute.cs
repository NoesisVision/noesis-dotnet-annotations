using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddRepositoryAttribute(string? name = null) : DomainObjectAttribute(name);