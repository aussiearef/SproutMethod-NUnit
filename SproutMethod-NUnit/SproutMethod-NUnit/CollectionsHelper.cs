namespace SproutMethod_NUnit;

public static class CollectionsHelper
{
    public static void JoinDictionaries<TKey, TValue>(Dictionary<TKey, TValue> fromDictionary,
        Dictionary<TKey, TValue> toDictionary) where TKey:notnull
    {
        foreach (var keyPair in fromDictionary)
        {
            toDictionary.Add(keyPair.Key, keyPair.Value);
        }
    }
}