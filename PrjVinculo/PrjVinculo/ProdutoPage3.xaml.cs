namespace PrjVinculo;

public partial class ProdutoPage3 : ContentPage
{
	public ProdutoPage3()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}