using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Struct |
    AttributeTargets.Enum)]
public class ExternalContractAttribute(string modelBoundary) : Attribute
{
    public string ModelBoundary { get; } = modelBoundary;
}