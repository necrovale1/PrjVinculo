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

            produto.Descricao = "Mouse Multilaser";
            produto.Preco = 30;
            produto.Categoria = "Informática";

            Navigation.PushAsync(new ProdutoPage() { BindingContext = produto });
        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Cadeira Gamer";
            produto.Preco = 300;
            produto.Categoria = "Móveis";

            Navigation.PushAsync(new ProdutoPage2() { BindingContext = produto });
        }

        private void btnCelular_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Asus Zenfone 12 Ultra";
            celular.Preco = 7199;
            celular.Camera = "50 Mp + 32 Mp + 13 Mp , Frontal 32 Mp F 2.5";
            celular.Capinha = true;

            Navigation.PushAsync(new CelularPage() { BindingContext = celular });

        }

        private void btnCelular2_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Asus ROG Phone 9 Pro";
            celular.Preco = 6920;
            celular.Camera = "50 Mp + 32 Mp + 13 Mp , Frontal 32 Mp F 2.5";
            celular.Capinha = true;

            Navigation.PushAsync(new CelularPage2() { BindingContext = celular });
        }

        private void btnCelular3_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Asus Zenfone 7 Pro";
            celular.Preco = 2000;
            celular.Camera = "64 Mp + 12 Mp + 8 Mp";
            celular.Capinha = true;

            Navigation.PushAsync(new CelularPage3() { BindingContext = celular });
        }

        private void btnCelular4_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Asus ZenFone Max Shot";
            celular.Preco = 1274;
            celular.Camera = "12 Mp + 5 Mp + 8 Mp , Frontal 8 Mp F 2 ";
            celular.Capinha = true;

            Navigation.PushAsync(new CelularPage4() { BindingContext = celular });
        }

        private void btnListaprodutos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaProdutoPage());

        }
    }
}