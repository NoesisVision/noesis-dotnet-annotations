using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class AdaptersLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Adapters";
}