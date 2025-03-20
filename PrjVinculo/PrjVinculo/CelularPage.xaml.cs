namespace PrjVinculo;

public partial class CelularPage : ContentPage
{
	public CelularPage()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}