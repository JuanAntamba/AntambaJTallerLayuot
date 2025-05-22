namespace AntambaJTallerLayuot
{
    public partial class AbsoluteLayoutPage : ContentPage
    {
        public AbsoluteLayoutPage()
        {
            InitializeComponent();
        }

        private void OnGoToGridClicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
