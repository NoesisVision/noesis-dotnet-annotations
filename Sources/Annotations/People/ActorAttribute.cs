using JetBrains.Annotations;

namespace NoesisVision.Annotations.People;

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