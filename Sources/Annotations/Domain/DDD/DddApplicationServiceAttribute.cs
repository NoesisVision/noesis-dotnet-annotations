using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain.DDD;

[PublicAPI]
public class DddApplicationServiceAttribute(string? name = null) : EntryPointAttribute(name);