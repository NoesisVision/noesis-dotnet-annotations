using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class AdaptersLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Adapters";
}