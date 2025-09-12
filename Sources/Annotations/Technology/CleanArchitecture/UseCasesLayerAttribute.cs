using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class UseCasesLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Use Cases";
}