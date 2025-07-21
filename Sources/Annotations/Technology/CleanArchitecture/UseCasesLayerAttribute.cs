using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class UseCasesLayerAttribute : LayerAttribute
{
    public new const string Name = "Use Cases";
    
    public UseCasesLayerAttribute() : base(Name) { }
}