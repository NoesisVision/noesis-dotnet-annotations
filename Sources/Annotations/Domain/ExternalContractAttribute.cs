using JetBrains.Annotations;

namespace NoesisVision.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Struct |
    AttributeTargets.Enum)]
public class ExternalContractAttribute(string modelBoundary) : Attribute
{
    public string ModelBoundary { get; } = modelBoundary;
}