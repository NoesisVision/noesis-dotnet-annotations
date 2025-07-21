using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddFactoryAttribute(string? name = null) : DomainBuildingBlockAttribute(name);