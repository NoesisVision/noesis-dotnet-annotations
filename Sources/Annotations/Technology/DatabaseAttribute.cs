using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class DatabaseAttribute : Attribute
{
    public string Name { get; }
    public string? ClusterName { get; init; }

    public DatabaseAttribute(string name) => Name = name;
}