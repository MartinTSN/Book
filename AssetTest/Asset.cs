class Asset
{
    private string assetName;
    private decimal assetValue;
    private decimal depricationRate;

    public Asset(string assetName, decimal assetValue, decimal depticationRate)
    {
        AssetName = assetName;
        AssetValue = assetValue;
        DepricationRate = depricationRate;
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
            return DepricationRate;
        }
        set
        {
            if (value > 0.0m)
            {
                DepricationRate = value;
            }
        }
    }
}