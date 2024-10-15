using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BlasII.Framework.UI;

/// <summary>
/// Useful methods to modify RectTransforms
/// </summary>
public static class RectExtensions
{
    // Application

    internal static RectTransform ApplyOptions(this RectTransform rect, RectCreationOptions options)
    {
        rect.name = options.Name;
        rect.SetParent(options.Parent, false);

        return rect
            .SetPivot(options.Pivot)
            .SetPosition(options.Position)
            .SetSize(options.Size)
            .SetXRange(options.XRange)
            .SetYRange(options.YRange);
    }

    internal static RectCreationOptions CopyOptions(this RectTransform rect)
    {
        return new RectCreationOptions()
        {
            Name = rect.name,
            Parent = rect.parent,
            XRange = new Vector2(rect.anchorMin.x, rect.anchorMax.x),
            YRange = new Vector2(rect.anchorMin.y, rect.anchorMax.y),
            Pivot = rect.pivot,
            Position = rect.anchoredPosition,
            Size = rect.sizeDelta
        };
    }

    // Modification

    /// <summary> Updates the sizeDelta property </summary>
    public static RectTransform SetSize(this RectTransform rect, float width, float height) =>
        rect.SetSize(new Vector2(width, height));

    /// <summary> Updates the sizeDelta property </summary>
    public static RectTransform SetSize(this RectTransform rect, Vector2 size)
    {
        rect.sizeDelta = size;
        return rect;
    }

    /// <summary> Updates the pivot property </summary>
    public static RectTransform SetPivot(this RectTransform rect, float x, float y) =>
        rect.SetPivot(new Vector2(x, y));

    /// <summary> Updates the pivot property </summary>
    public static RectTransform SetPivot(this RectTransform rect, Vector2 pivot)
    {
        rect.pivot = pivot;
        return rect;
    }

    /// <summary> Updates the anchoredPosition property </summary>
    public static RectTransform SetPosition(this RectTransform rect, float x, float y) =>
        rect.SetPosition(new Vector2(x, y));

    /// <summary> Updates the anchoredPosition property </summary>
    public static RectTransform SetPosition(this RectTransform rect, Vector2 position)
    {
        rect.anchoredPosition = position;
        return rect;
    }

    /// <summary> Modifies the anchoredPosition property </summary>
    public static RectTransform ChangePosition(this RectTransform rect, float x, float y) =>
        rect.ChangePosition(new Vector2(x, y));

    /// <summary> Modifies the anchoredPosition property </summary>
    public static RectTransform ChangePosition(this RectTransform rect, Vector2 position)
    {
        rect.anchoredPosition += position;
        return rect;
    }

    /// <summary> Updates the anchorMin.x and anchorMax.x properties </summary>
    public static RectTransform SetXRange(this RectTransform rect, float min, float max) =>
        rect.SetXRange(new Vector2(min, max));

    /// <summary> Updates the anchorMin.x and anchorMax.x properties </summary>
    public static RectTransform SetXRange(this RectTransform rect, Vector2 range)
    {
        rect.anchorMin = new Vector2(range.x, rect.anchorMin.y);
        rect.anchorMax = new Vector2(range.y, rect.anchorMax.y);
        return rect;
    }

    /// <summary> Updates the anchorMin.y and anchorMax.y properties </summary>
    public static RectTransform SetYRange(this RectTransform rect, float min, float max) =>
        rect.SetYRange(new Vector2(min, max));

    /// <summary> Updates the anchorMin.y and anchorMax.y properties </summary>
    public static RectTransform SetYRange(this RectTransform rect, Vector2 range)
    {
        rect.anchorMin = new Vector2(rect.anchorMin.x, range.x);
        rect.anchorMax = new Vector2(rect.anchorMax.x, range.y);
        return rect;
    }

    // Addition

    /// <summary>
    /// Adds an Image component with the specified options
    /// </summary>
    public static Image AddImage(this RectTransform rect, ImageCreationOptions options)
    {
        return rect.gameObject.AddComponent<Image>().ApplyOptions(options);
    }

    /// <summary>
    /// Adds an Image component with default options
    /// </summary>
    public static Image AddImage(this RectTransform rect) => rect.AddImage(new ImageCreationOptions());

    /// <summary>
    /// Adds a TextMeshProUGUI component with the specified options
    /// </summary>
    public static TextMeshProUGUI AddText(this RectTransform rect, TextCreationOptions options)
    {
        return rect.gameObject.AddComponent<TextMeshProUGUI>().ApplyOptions(options);
    }

    /// <summary>
    /// Adds a TextMeshProUGUI component with default options
    /// </summary>
    public static TextMeshProUGUI AddText(this RectTransform rect) => rect.AddText(new TextCreationOptions());
}
