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
        return image
            .SetColor(options.Color)
            .SetSprite(options.Sprite);
    }

    internal static ImageCreationOptions CopyOptions(this Image image)
    {
        return new ImageCreationOptions()
        {
            Color = image.color,
            Sprite = image.sprite,
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
}
