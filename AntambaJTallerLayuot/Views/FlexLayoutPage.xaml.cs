namespace AntambaJTallerLayuot
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToAbsoluteClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsoluteLayoutPage());
        }
    }
}
