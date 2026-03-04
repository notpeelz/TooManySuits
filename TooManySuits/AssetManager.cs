using System.Reflection;
using TMPro;
using UnityEngine;

namespace TooManySuits;

internal class AssetManager
{
    public TMP_FontAsset Vga437Font { get; private set; }

    public AssetManager()
    {
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream("TooManySuits.AssetBundle")
            ?? throw new InvalidOperationException("Failed to load AssetBundle");
        var assetBundle = AssetBundle.LoadFromStream(stream);

        Vga437Font = assetBundle.LoadAsset<TMP_FontAsset>("Perfect DOS VGA 437 SDF")
            ?? throw new InvalidOperationException("Failed to load font 'Perfect DOS VGA 437 SDF' from AssetBundle");
    }
}
