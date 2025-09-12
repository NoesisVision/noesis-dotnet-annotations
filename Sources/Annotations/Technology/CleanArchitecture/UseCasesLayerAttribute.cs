using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class UseCasesLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Use Cases";
}