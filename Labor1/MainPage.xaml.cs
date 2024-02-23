namespace Labor1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", $"Szia {entry.Text}", "Cancel");
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = e.NewTextValue;
        }
    }

}
