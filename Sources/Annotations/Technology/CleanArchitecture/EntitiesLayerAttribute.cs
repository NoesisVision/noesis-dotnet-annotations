using JetBrains.Annotations;

namespace NoesisVision.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class EntitiesLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Entities";
}