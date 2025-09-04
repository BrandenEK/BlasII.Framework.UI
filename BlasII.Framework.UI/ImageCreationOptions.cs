using UnityEngine;
using UnityEngine.UI;

namespace BlasII.Framework.UI;

/// <summary>
/// Settings used when creating a new Image
/// </summary>
public class ImageCreationOptions
{
    /// <summary> Default: White </summary>
    public Color Color { get; init; } = Color.white;

    /// <summary> Default: null </summary>
    public Sprite Sprite { get; init; } = null;

    /// <summary> Default: Simple </summary>
    public Image.Type Type { get; init; } = Image.Type.Simple;
}
