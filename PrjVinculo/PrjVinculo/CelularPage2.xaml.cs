namespace PrjVinculo;

public partial class CelularPage2 : ContentPage
{
	public CelularPage2()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}