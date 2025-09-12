using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class FrameworkLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Framework";
}