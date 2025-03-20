namespace PrjVinculo;

public partial class CelularPage3 : ContentPage
{
	public CelularPage3()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}