class Asset
{
    private string assetName;
    private decimal assetValue;
    private decimal depricationRate;

    public Asset(string assetsName, decimal assetsValue, decimal depticationsRate)
    {
        AssetName = assetsName;
        AssetValue = assetsValue;
        DepricationRate = depticationsRate;
    }

    public string AssetName
    {
        get
        {
            return assetName;
        }
        set
        {
            assetName = value;
        }
    }
    public decimal AssetValue
    {
        get
        {
            return assetValue;
        }
        set
        {
            if (value > 0.0m)
            {
                assetValue = value;
            }
        }
    }
    public decimal DepricationRate
    {
        get
        {
            return depricationRate;
        }
        set
        {
            if (value > 0.0m)
            {
                depricationRate = value;
            }
        }
    }
}