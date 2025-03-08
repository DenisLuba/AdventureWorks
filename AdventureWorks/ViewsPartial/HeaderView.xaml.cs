namespace AdventureWorks.ViewsPartial;

public partial class HeaderView : ContentView
{
    public static readonly BindableProperty ViewTitleProperty =
        BindableProperty.Create(
            propertyName: nameof(ViewTitle),    // имя свойства
            returnType: typeof(string),               // тип данных свойства
            declaringType: typeof(HeaderView),  // тип класса, в котором объявляется свойство
            defaultValue: string.Empty);             // значение по умолчанию

    public string ViewTitle
    {
        get => GetValue(ViewTitleProperty) as string ?? string.Empty;
        set => SetValue(ViewTitleProperty, value);
    }

    public static readonly BindableProperty ViewDescriptionProperty =
        BindableProperty.Create(
            propertyName: nameof(ViewDescription),
            returnType: typeof(string),
            declaringType: typeof(HeaderView),
            defaultValue: string.Empty);

    public string ViewDescription
    {
        get => GetValue(ViewDescriptionProperty) as string ?? string.Empty;
        set => SetValue(ViewDescriptionProperty, value);
    }

    public HeaderView()
	{
		InitializeComponent();

        ViewTitle = "View Title";
        ViewDescription = "View Description";

        BindingContext = this;
	}
}