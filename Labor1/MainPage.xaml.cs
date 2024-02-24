namespace Labor1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            label.Text = "Szia " + e.NewTextValue;
        }
    }

}
