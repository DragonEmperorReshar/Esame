namespace Esame
{
    public partial class MainPage : ContentPage
    {
        RestService restService;
        List<Product> Items;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
           var service = new RestService();
           var products = await service.GetProductsAsync();
        }

        private async void OnSelectionChanged(object sender, EventArgs e)
        {
            await Shell = (GoToAsync)
            //var service = new RestService();
            //var prducts = await service.GetProductsAsync(product);
        }
    }

}
