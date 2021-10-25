using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using MobileUno.DataTemplate;
using MobileUno.ViewModels;

namespace MobileUno.Views;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		InitializeComponent();
	}

	private MainViewModel ViewModel => (MainViewModel) DataContext;

	private void AddHomeItem(string description, string iconName)
	{
		ViewModel.HomeItems.Add(new HomeItem(description)
		{
			PrimaryPath = (string) Application.Current.Resources[$"Icon{iconName}Primary"],
			SecondaryPath = (string) Application.Current.Resources[$"Icon{iconName}Secondary"],
		});
	}

	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);

		// Commented out items have too broken icons

		AddHomeItem("Reseräkning", "Globe");
		AddHomeItem("Körjournal", "CarSedan");
		AddHomeItem("Fotografera kvitto", "Camera");

		//AddHomeItem("Spela in bilresa", "CarSedan");
		AddHomeItem("Mitt schema", "Calendar7");
		AddHomeItem("Stämpling", "StartClock");

		AddHomeItem("Tidrapport", "History2");
		//AddHomeItem("Tidsaldon", "Tidsaldo");
		//AddHomeItem("Frånvaro", "Franvaroansokan");

		AddHomeItem("Mina kollegor", "MinaKollegor");
		AddHomeItem("Meddelanden", "Mail");
		AddHomeItem("Uppgifter", "Assignment");
	}
}