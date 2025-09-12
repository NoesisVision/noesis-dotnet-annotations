using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class FrameworkLayerAttribute() : LayerAttribute(Name)
{
    public new const string Name = "Framework";
}