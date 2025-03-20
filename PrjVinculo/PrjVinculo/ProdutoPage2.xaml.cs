namespace PrjVinculo;

public partial class ProdutoPage2 : ContentPage
{
	public ProdutoPage2()
	{
		InitializeComponent();
	}
    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}