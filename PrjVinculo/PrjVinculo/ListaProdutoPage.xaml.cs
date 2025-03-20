namespace PrjVinculo;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
		List<Produto> lista = new List<Produto>();

		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}