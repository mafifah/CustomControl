using Microsoft.Maui.Graphics.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Test.CustomControls;

public partial class EntriControl : Grid
{
	public EntriControl()
	{
		InitializeComponent();
	}

    #region BorderColor
    public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
        propertyName: nameof(BorderColor),
        returnType: typeof(Color),
        defaultValue: Colors.Gray,
        declaringType: typeof(EntriControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public Color BorderColor { get => (Color)GetValue(BorderColorProperty); set => SetValue(BorderColorProperty, value); }
    #endregion

    #region TextColor
    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
        propertyName: nameof(TextColor),
        returnType: typeof(Color),
        defaultValue: Colors.Black,
        declaringType: typeof(EntriControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public Color TextColor { get => (Color)GetValue(TextColorProperty); set => SetValue(TextColorProperty, value); }
    #endregion

    #region Text
    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        propertyName: nameof(Text),
        returnType: typeof(string),
        defaultValue: null,
        declaringType: typeof(EntriControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }
    #endregion

    #region Placeholder
    public static readonly BindableProperty PlaceholderProperty = BindableProperty.Create(
        propertyName: nameof(Placeholder),
        returnType: typeof(string),
        defaultValue: null,
        declaringType: typeof(EntriControl),
        defaultBindingMode: BindingMode.OneWay
        );

    public string Placeholder { get => (string)GetValue(PlaceholderProperty); set => SetValue(PlaceholderProperty, value); }
    #endregion

    private void textEntri_Focused(object sender, FocusEventArgs e)
    {
        placeholder.FontSize = 15;
        placeholder.FontAttributes = FontAttributes.Bold;
        placeholder.TranslateTo(0, -26, 80, easing: Easing.Linear);
    }

    private void textEntri_Unfocused(object sender, FocusEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Text))
        {
            placeholder.FontSize = 15;
            placeholder.FontAttributes= FontAttributes.Bold;
            placeholder.TranslateTo(0, -26, 80, easing: Easing.Linear);
        }
        else
        {
            placeholder.FontSize = 20;
            placeholder.TranslateTo(0, 0, 80, easing: Easing.Linear);
        }
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        textEntri.Focus();
    }
}