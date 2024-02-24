namespace Labor1;

public partial class Feladat2Page : ContentPage
{
	public Feladat2Page()
	{
		InitializeComponent();
	}

    private void OnButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert("", $"Szia {entry.Text}!", "OK");
    }
}