using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class EntitiesLayerAttribute : LayerAttribute
{
    public new const string Name = "Entities";
    
    public EntitiesLayerAttribute() : base(Name) { }
}