## .net-maui-ui
Ejemplo UI .Net MAUI, básico. Modificado con fines didácticos. Original: https://www.youtube.com/watch?v=EXznxjxqN_g
> UI Pages: ContentPage, FlyoutPage, NavigationPage yTabbedPage. 📱


## Nota:
En App.xaml.cs, segun la UI page que se ejemplifica se aplica o ignora el código correspondiente: 
```
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
```
