using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddBoundedContextAttribute(string? name = null) : DomainModuleAttribute(name);