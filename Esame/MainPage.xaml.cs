using AudioToolbox;
using System.Text.Json.Nodes;

namespace Esame
{
    public partial class MainPage : ContentPage
    {
        RestService restService;
        List<Product> Items;



        public MainPage()
        {
            InitializeComponent();
            var service = new RestService(); 
                BindingContext = this;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
           var service = new RestService();
           var products = await service.GetProductsAsync();
        }

        protected async override void OnNavigatedTo(NavigationEventArgs args)
        {
            base.OnNavigatedTo(args);
            var products = await ServiceCollection.GetProductsAsync();
            foreach (var p in products)
            {
                Items.Add(p);
            }

        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is not Product item)
                return;

            await Shell.Current.GoToAsync(nameof(Product), true, new Dictionary<string, object>
            {
                ["Item"] = item
            });


            //var service = new RestService();
            //var prducts = await service.GetProductsAsync(product);
        }
    }

}
