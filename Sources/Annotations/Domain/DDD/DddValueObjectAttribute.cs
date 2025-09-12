using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddValueObjectAttribute(string? name = null) : DomainObjectAttribute(name);