namespace Maui_IssueScrollToAsync2;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private async void btnBack_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.Navigation.PopAsync(false);
    }
}