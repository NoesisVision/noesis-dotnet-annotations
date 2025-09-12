using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddEntityAttribute(string? name = null) : DomainObjectAttribute(name);