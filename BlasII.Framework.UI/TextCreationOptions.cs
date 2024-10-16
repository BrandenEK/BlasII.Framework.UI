﻿using Il2CppTMPro;
using UnityEngine;

namespace BlasII.Framework.UI;

/// <summary>
/// Settings used when creating a new TextMeshProUGUI
/// </summary>
public class TextCreationOptions
{
    /// <summary> Default: Centered </summary>
    public TextAlignmentOptions Alignment { get; init; } = TextAlignmentOptions.Center;

    /// <summary> Default: White </summary>
    public Color Color { get; init; } = Color.white;

    /// <summary> Default: "" </summary>
    public string Contents { get; init; } = string.Empty;

    /// <summary> Default: Blasphemous </summary>
    public TMP_FontAsset Font { get; init; } = UIModder.Fonts.Blasphemous;

    /// <summary> Default: 16.0 </summary>
    public float FontSize { get; init; } = 16f;

    /// <summary> Default: false </summary>
    public bool UseRichText { get; init; } = false;

    /// <summary> Default: false </summary>
    public bool WordWrap { get; init; } = false;
}
