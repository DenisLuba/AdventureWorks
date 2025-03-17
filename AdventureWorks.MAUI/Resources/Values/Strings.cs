namespace AdventureWorks.Resources.Values;

class Strings : ResourceDictionary
{
    Dictionary<string, string> dictionary = new()
    {
        { "ApplicationTitle", "Adventure Works" },
        { "UserDetailTitle", "User Information" },
        { "LoginTitle", "Login" },
        { "CustomerDetailTitle", "Customer Information" },
        { "ColorListTitle", "Color List" },
        { "PhoneTypesListTitle", "Phone Types List" },
        { "ProductDetailTitle", "Product Information" },
        { "UserListTitle", "User List" },
        { "ProductListTitle", "Product List" }
    };

    public Strings()
    {
        foreach (var item in dictionary)
            Add(item.Key, item.Value);
    }
}
