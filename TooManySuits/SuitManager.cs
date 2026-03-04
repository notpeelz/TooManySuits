using UnityEngine;

namespace TooManySuits;

internal class SuitManager
{
    public event Action? SuitsUpdated;

    public static IEnumerable<UnlockableSuit> GetUnlockedSuits()
    {
        return Resources.FindObjectsOfTypeAll<UnlockableSuit>()
            .OrderBy(suit => suit.syncedSuitID.Value)
            .Where(suit => suit.IsSpawned);
    }

    internal void UpdateSuits()
    {
        SuitsUpdated?.Invoke();
    }
}
