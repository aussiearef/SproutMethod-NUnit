// See https://aka.ms/new-console-template for more information

using SproutMethod_NUnit;

Console.Clear();

var fromDictionary = new Dictionary<int, string>() { {100, "John"}, {200, "Sarah"}};
var toDictionary = new Dictionary<int, string>() { {100, "John"}, {300, "Lucy"}};

CollectionsHelper.JoinDictionaries(fromDictionary, toDictionary);

foreach (var item in toDictionary)
{
    Console.WriteLine("Key={0} and Value={1}",item.Key, item.Value);
}

Console.WriteLine("Press any key...");
Console.ReadKey();
