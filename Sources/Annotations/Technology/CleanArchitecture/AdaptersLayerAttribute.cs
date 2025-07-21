using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class AdaptersLayerAttribute : LayerAttribute
{
    public new const string Name = "Adapters";
    
    public AdaptersLayerAttribute() : base(Name) { }
}