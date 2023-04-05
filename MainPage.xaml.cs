namespace TeamCalender;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

  //private void OnCounterClicked(object sender, EventArgs e)
  //{
  //	count++;

  //	if (count == 1)
  //		CounterBtn.Text = $"Clicked {count} time";
  //	else
  //		CounterBtn.Text = $"Clicked {count} times";

  //	SemanticScreenReader.Announce(CounterBtn.Text);
  //}
  public void OnNewButtonClicked(object sender, EventArgs args)
  {

    App.repository.inertItem(newItem.Text);
  }
  public void OnGetButtonClicked(object sender, EventArgs args)
  {

    List<DemoTable> people = App.repository.GetAllItem();
    peopleList.ItemsSource = people;
  }
}

