using Windows.UI.Xaml.Controls;
using MobileUno.ViewModels;

namespace MobileUno.Views
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}