using JetBrains.Annotations;

namespace Noesis.P3.Annotations.Domain;

[PublicAPI]
[AttributeUsage(AttributeTargets.All)]
public class ExcludeFromDomainGlossaryAttribute : Attribute, DomainPerspectiveAttribute;