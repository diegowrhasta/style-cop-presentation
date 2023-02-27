namespace Playground;

public struct Category : IBank
{
    private int _categoryId;
    private string? _categoryName;

    public Category()
    {
    }

    public int CategoryId
    {
        set
        {
            if (value is >= 1 and <= 100)
            {
                _categoryId = value;
            }
        }

        get => _categoryId;
    }

    public string CategoryName
    {
        set
        {
            if (value.Length <= 40)
            {
                _categoryName = value;
            }
        }

        get => _categoryName;
    }

    public int GetCategoryNameLength => this._categoryName.Length;

    public void DoBankStuff()
    {
        // Yeah
        Console.WriteLine("I am Category brah");
    }
}