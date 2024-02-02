namespace MyFirstMauiApplication;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void OnShopClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Home());
    }
}