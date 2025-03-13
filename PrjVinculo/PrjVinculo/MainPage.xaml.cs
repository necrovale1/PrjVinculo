namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = "Monitor";
            produto.Preco = 30;
            produto.Categoria = "Informática";

            Navigation.PushAsync(new ProdutoPage() {BindingContext = produto});
        }

    }
}
