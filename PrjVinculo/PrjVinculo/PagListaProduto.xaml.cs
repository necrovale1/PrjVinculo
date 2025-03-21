namespace PrjVinculo;

public partial class PagListaProduto : ContentPage
{
	public PagListaProduto()
	{
		InitializeComponent();
		List<Produto> lista = new List<Produto>();

		lista.Add(
			new Produto
			{
				Categoria = "Eletrodomesticos",
				Descricao = "Geladeira",
				Preco = 8500
			}

        );

        lista.Add(
            new Produto
            {
            Categoria = "Eletrodomesticos",
			Descricao = "Microondas",
			Preco = 2300
            }

		);

		lstProduto.ItemsSource = lista;
	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
		var context = (sender as ViewCell).BindingContext;
		Navigation.PushAsync(new ProdutoPage { BindingContext = context });

		(sender as ViewCell).BindingContext = lstProduto;
    }
}