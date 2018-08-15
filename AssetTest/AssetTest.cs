using System;

class AssetTest
{
    static void Main()
    {
        Asset asset1 = new Asset("something", 1000.0m, 10.0m);
        Asset asset2 = new Asset("need9line", 500.0m, 5.0m);

        Console.Write($"Name: {asset1.AssetName}, Deprecation: {(asset1.AssetValue / 100.0m) * asset1.DepricationRate}, DeprecationRate: {asset1.DepricationRate}");
        Console.Write($"\nName: {asset2.AssetName}, Deprecation: {(asset2.AssetValue / 100.0m) * asset2.DepricationRate}, DeprecationRate: {asset2.DepricationRate}");

        Console.Write("\n");
        Console.Write("\n");

        asset1.AssetValue = (asset1.AssetValue / 100.0m) * 5.0m + asset1.AssetValue;
        asset2.AssetValue = (asset2.AssetValue / 100.0m) * 5.0m + asset2.AssetValue;
        Console.Write($"Name: {asset1.AssetName}, Deprecation: {(asset1.AssetValue / 100.0m) * asset1.DepricationRate}, DeprecationRate: {asset1.DepricationRate}");
        Console.Write($"\nName: {asset2.AssetName}, Deprecation: {(asset2.AssetValue / 100.0m) * asset2.DepricationRate}, DeprecationRate: {asset2.DepricationRate}");
        Console.ReadLine();
    }
}

