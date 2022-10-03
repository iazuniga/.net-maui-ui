namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        
		var navPage = new NavigationPage(new MainPage());

		navPage.BarBackground = Colors.Chocolate;
        navPage.BarTextColor = Colors.White;
        //MainPage = navPage;

         MainPage = new TabbedPageDemo();
        // MainPage = new MainPage();
        // MainPage = new ContentPageDemo();
        // MainPage = new NavigationPage(new MainPage());
        //MainPage = new FlyoutPageDemo();
    }
}