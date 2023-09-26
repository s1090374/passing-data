namespace passing_data
{
    public partial class MainPage : ContentPage
    {
        List<string> list = new List<string>() { "Apple", "Banana","Orange","Guava","Peach","Melon"};
        
        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}