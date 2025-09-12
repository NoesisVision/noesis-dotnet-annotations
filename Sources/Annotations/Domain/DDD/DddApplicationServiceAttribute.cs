using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain.DDD;

[PublicAPI]
public class DddApplicationServiceAttribute(string? name = null) : EntryPointAttribute(name);