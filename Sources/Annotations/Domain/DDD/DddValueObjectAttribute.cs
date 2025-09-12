using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddValueObjectAttribute(string? name = null) : DomainObjectAttribute(name);