namespace TeamCalender;

public partial class App : Application
{
  public static DemoTblRepository repository { get; private set; }

  public App(DemoTblRepository repo)
	{
		InitializeComponent();

		MainPage = new AppShell();

    repository = repo;
  }
  protected override void OnStart()
  {
    base.OnStart();
  }

  protected override void OnResume()
  {
    base.OnResume();
  }

  protected override void OnSleep()
  {
    base.OnSleep();
  }
}
