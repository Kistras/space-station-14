using Robust.Shared.Prototypes;

namespace Content.Shared.SprayPainter.Prototypes;

[Prototype("AirlockGroup")]
public sealed class AirlockGroupPrototype : IPrototype
{
    [IdDataField]
    public string ID { get; } = default!;

    [DataField("stylePaths")]
    public Dictionary<string, string> StylePaths = default!;

    // The priority determines, which sprite is used when showing
    // the icon for a style in the SprayPainter UI. The highest priority
    // gets shown.
    [DataField("iconPriority")]
    public int IconPriority = 0;
}
