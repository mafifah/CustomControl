namespace Test.CustomControls;

public partial class LoaderControl : StackLayout
{
	public LoaderControl()
	{
		InitializeComponent();
	}

    #region LoaderColor
    public static readonly BindableProperty LoaderColorProperty = BindableProperty.Create(
        propertyName: nameof(LoaderColor),
        returnType: typeof(Color),
        defaultValue: Colors.Black,
        declaringType: typeof(LoaderControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public Color LoaderColor { get => (Color)GetValue(LoaderColorProperty); set => SetValue(LoaderColorProperty, value); }
    #endregion

    #region LoaderText
    public static readonly BindableProperty LoaderTextProperty = BindableProperty.Create(
        propertyName: nameof(LoaderText),
        returnType: typeof(string),
        defaultValue: "Please wait...",
        declaringType: typeof(LoaderControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public string LoaderText { get => (string)GetValue(LoaderTextProperty); set => SetValue(LoaderTextProperty, value); }
    #endregion

}