using BlasII.ModdingAPI;

namespace BlasII.Framework.UI;

public class UIFramework : BlasIIMod
{
    internal UIFramework() : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION) { }

    protected override void OnInitialize()
    {
        // Perform initialization here
    }
}
