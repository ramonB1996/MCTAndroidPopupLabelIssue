using CommunityToolkit.Maui.Views;
using StackLayout = Microsoft.Maui.Controls.Compatibility.StackLayout;

namespace MCTAndroidPopupLabelIssue.Maui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        this.ShowPopup(new Popup());
    }
}