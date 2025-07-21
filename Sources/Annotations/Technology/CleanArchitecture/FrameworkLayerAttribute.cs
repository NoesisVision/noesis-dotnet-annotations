using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Technology.CleanArchitecture;

[PublicAPI]
public class FrameworkLayerAttribute : LayerAttribute
{
    public new const string Name = "Framework";

    public FrameworkLayerAttribute() : base(Name) { }
}