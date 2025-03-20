namespace PrjVinculo;

public partial class CelularPage4 : ContentPage
{
	public CelularPage4()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}