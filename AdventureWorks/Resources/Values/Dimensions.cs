namespace AdventureWorks.Resources.Values;

class Dimensions : ResourceDictionary
{
    const double DefaultSpacingForGrid = 10;

    public Dimensions()
    {
        Add(nameof(DefaultSpacingForGrid), DefaultSpacingForGrid);
    }
}
