using Il2CppTGK.Game.Components.UI;
using Il2CppTMPro;
using UnityEngine;

namespace BlasII.Framework.UI;

/// <summary>
/// Useful methods to modify TextMeshProUGUIs
/// </summary>
public static class TextExtensions
{
    // Application

    internal static TextMeshProUGUI ApplyOptions(this TextMeshProUGUI text, TextCreationOptions options)
    {
        return text
            .SetAlignment(options.Alignment)
            .SetColor(options.Color)
            .SetContents(options.Contents)
            .SetFont(options.Font)
            .SetFontSize(options.FontSize)
            .SetUseRichText(options.UseRichText)
            .SetWordWrap(options.WordWrap)
            .SetOverflowMode(options.OverflowMode);
    }

    internal static TextCreationOptions CopyOptions(this TextMeshProUGUI text)
    {
        return new TextCreationOptions()
        {
            Alignment = text.alignment,
            Color = text.color,
            Contents = text.text,
            Font = text.font,
            FontSize = text.fontSize,
            UseRichText = text.richText,
            WordWrap = text.enableWordWrapping,
            OverflowMode = text.overflowMode,
        };
    }

    // Modification

    /// <summary> Updates the alignment property </summary>
    public static TextMeshProUGUI SetAlignment(this TextMeshProUGUI text, TextAlignmentOptions alignment)
    {
        text.alignment = alignment;
        return text;
    }

    /// <summary> Updates the color property </summary>
    public static TextMeshProUGUI SetColor(this TextMeshProUGUI text, Color color)
    {
        text.color = color;
        return text;
    }

    /// <summary> Updates the text property </summary>
    public static TextMeshProUGUI SetContents(this TextMeshProUGUI text, string contents)
    {
        text.text = contents;
        return text;
    }

    /// <summary> Updates the font property </summary>
    public static TextMeshProUGUI SetFont(this TextMeshProUGUI text, TMP_FontAsset font)
    {
        text.font = font;
        return text;
    }

    /// <summary> Updates the fontSize property </summary>
    public static TextMeshProUGUI SetFontSize(this TextMeshProUGUI text, float fontSize)
    {
        text.fontSize = fontSize;
        return text;
    }

    /// <summary> Updates the richText property </summary>
    public static TextMeshProUGUI SetUseRichText(this TextMeshProUGUI text, bool useRichText)
    {
        text.richText = useRichText;
        return text;
    }

    /// <summary> Updates the enableWordWrapping property </summary>
    public static TextMeshProUGUI SetWordWrap(this TextMeshProUGUI text, bool wordWrap)
    {
        text.enableWordWrapping = wordWrap;
        return text;
    }

    /// <summary> Updates the overflowMode property </summary>
    public static TextMeshProUGUI SetOverflowMode(this TextMeshProUGUI text, TextOverflowModes overflowMode)
    {
        text.overflowMode = overflowMode;
        return text;
    }

    // Addition

    /// <summary>
    /// Turns the text object into a UIPixelTextWithShadow
    /// </summary>
    public static UIPixelTextWithShadow AddShadow(this TextMeshProUGUI text)
    {
        // Create new overhead text
        var newText = UIModder.Create(new RectCreationOptions()
        {
            Name = "Text",
            Parent = text.transform,
            Position = new Vector2(0, 4),
            Size = text.rectTransform.sizeDelta
        }).AddText(text.CopyOptions());

        // Update old shadow text
        text.rectTransform.ChangePosition(0, -2);
        text.SetColor(new Color(0.004f, 0.008f, 0.008f));

        // Add pixel text component
        UIPixelTextWithShadow shadow = text.gameObject.AddComponent<UIPixelTextWithShadow>();
        shadow.normalText = newText;
        shadow.shadowText = text;
        return shadow;
    }
}
