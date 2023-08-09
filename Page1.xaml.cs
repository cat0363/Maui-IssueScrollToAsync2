using System.Collections.ObjectModel;

namespace Maui_IssueScrollToAsync2;

public partial class Page1 : ContentPage
{
	public ObservableCollection<TestItem> TestItems = new ObservableCollection<TestItem>();

	public Page1()
	{
		InitializeComponent();

        for (int i = 0; i < 100; i++)
        {
            TestItems.Add(new TestItem() { ItemName = "ItemName" + (i + 1) });
        }
        BindableLayout.SetItemsSource(slTestItem, TestItems);
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        txtLog.Text += ("Before ScrollToAsync" + Environment.NewLine);
        await svTestItem.ScrollToAsync(0, 200, false);
        txtLog.Text += ("After ScrollToAsync" + Environment.NewLine);
    }

    /*
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        txtLog.Text += ("Before ScrollToAsync" + Environment.NewLine);
        await svTestItem.ScrollToAsync(0, 200, false);
        txtLog.Text += ("After ScrollToAsync" + Environment.NewLine);
    }
    */

    private async void btnNext_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PushAsync(new Page2(), false); 
    }
}

public class TestItem
{
	public string ItemName { get; set; }
}

