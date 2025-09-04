using UnityEngine;
using UnityEngine.UI;

namespace BlasII.Framework.UI;

/// <summary>
/// Useful methods to modify Images
/// </summary>
public static class ImageExtensions
{
    // Application

    internal static Image ApplyOptions(this Image image, ImageCreationOptions options)
    {
        image.pixelsPerUnitMultiplier = 3;

        return image
            .SetColor(options.Color)
            .SetSprite(options.Sprite)
            .SetType(options.Type);
    }

    internal static ImageCreationOptions CopyOptions(this Image image)
    {
        return new ImageCreationOptions()
        {
            Color = image.color,
            Sprite = image.sprite,
            Type = image.type,
        };
    }

    // Modification

    /// <summary> Updates the color property </summary>
    public static Image SetColor(this Image image, Color color)
    {
        image.color = color;
        return image;
    }

    /// <summary> Updates the sprite property </summary>
    public static Image SetSprite(this Image image, Sprite sprite)
    {
        image.sprite = sprite;
        return image;
    }

    /// <summary> Updates the type property </summary>
    public static Image SetType(this Image image, Image.Type type)
    {
        image.type = type;
        return image;
    }
}
