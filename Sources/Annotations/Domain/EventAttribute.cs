using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
public class EventAttribute : Attribute;