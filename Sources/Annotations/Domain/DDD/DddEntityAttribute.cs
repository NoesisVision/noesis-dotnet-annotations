using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddEntityAttribute(string? name = null) : DomainObjectAttribute(name);