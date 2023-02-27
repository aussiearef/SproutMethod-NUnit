using SproutMethod_NUnit;

namespace SproutMethod_NUnit_Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public static void JoinDictionaries_Given_DuplicateKeyPair_Then_RaisesException()
    {
        var fromDictionary = new Dictionary<int, string>() { {100, "John"}, {200, "Sarah"}};
        var toDictionary = new Dictionary<int, string>() { {100, "John"}, {300, "Lucy"}};

        Assert.DoesNotThrow(() => {CollectionsHelper.JoinDictionaries(fromDictionary, toDictionary); });
    }

    [Test]
    public static void GetDifferences_Given_TwoDictionaries_ReturnsDifferentKeyPairs()
    {
        var fromDictionary = new Dictionary<int, string>() { {100, "John"}, {200, "Sarah"}};
        var toDictionary = new Dictionary<int, string>() { {100, "John"}, {300, "Lucy"}};

        var differences = CollectionsHelper.GetDifferences(fromDictionary, toDictionary);
        var item = differences.FirstOrDefault();
        
        Assert.Multiple(() =>
        {
            Assert.NotNull(item);
            Assert.AreEqual(200, item.Key);
            Assert.AreEqual("Sarah", item.Value);
        });
    }
}