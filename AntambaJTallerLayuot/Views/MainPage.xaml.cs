namespace AntambaJTallerLayuot
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGoToStackClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutPage());
        }
    }
}
