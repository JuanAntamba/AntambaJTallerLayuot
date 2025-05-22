namespace AntambaJTallerLayuot
{
    public partial class StackLayoutPage : ContentPage
    {
        public StackLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToFlexClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlexLayoutPage());
        }
    }
}
