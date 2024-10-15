using BlasII.ModdingAPI;
using BlasII.ModdingAPI.Helpers;

namespace BlasII.Framework.UI;

/// <summary>
/// Framework that allows other mods to easily create UI
/// </summary>
public class UIFramework : BlasIIMod
{
    internal UIFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    private bool _initialized = false;

    /// <summary>
    /// Initialize storages when loading menu
    /// </summary>
    protected override void OnSceneLoaded(string _)
    {
        if (_initialized || !SceneHelper.MenuSceneLoaded)
            return;

        UIModder.Fonts.Initialize();
        UIModder.Parents.Initialize();
        _initialized = true;
    }
}
