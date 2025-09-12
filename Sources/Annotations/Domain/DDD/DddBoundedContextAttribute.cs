using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddBoundedContextAttribute(string? name = null) : DomainModuleAttribute(name);