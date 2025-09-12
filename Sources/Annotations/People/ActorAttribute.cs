using JetBrains.Annotations;

namespace Noesis.P3.Annotations.People;

[PublicAPI]
[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Delegate |
                AttributeTargets.Method)]
public class ActorAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}