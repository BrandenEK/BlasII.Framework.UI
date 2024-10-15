using MelonLoader;

namespace BlasII.Framework.UI;

internal class Main : MelonMod
{
    public static UIFramework UIFramework { get; private set; }

    public override void OnLateInitializeMelon()
    {
        UIFramework = new UIFramework();
    }
}