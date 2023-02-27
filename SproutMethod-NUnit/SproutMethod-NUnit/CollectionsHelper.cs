using System.Net.NetworkInformation;

namespace SproutMethod_NUnit;

public static class CollectionsHelper
{
    public static Dictionary<TKey, TValue> GetDifferences<TKey, TValue>(Dictionary<TKey, TValue> fromDictionary,
        Dictionary<TKey, TValue> toDictionary) where TKey: notnull
    {
        var result = new Dictionary<TKey, TValue>();

        foreach (var keyPair in fromDictionary)
        {
            if (!toDictionary.ContainsKey(keyPair.Key))
            {
                result.Add(keyPair.Key, keyPair.Value);
            }
        }
        return result;
    }
    public static void JoinDictionaries<TKey, TValue>(Dictionary<TKey, TValue> fromDictionary,
        Dictionary<TKey, TValue> toDictionary) where TKey:notnull
    {
        var differences = GetDifferences(fromDictionary, toDictionary);
        
        foreach (var keyPair in differences)
        {
            toDictionary.Add(keyPair.Key, keyPair.Value);
        }
    }
}