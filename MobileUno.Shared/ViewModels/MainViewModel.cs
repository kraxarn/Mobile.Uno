using System;
using System.Collections.ObjectModel;
using System.Linq;
using MobileUno.DataTemplate;
using MobileUno.Extensions;

namespace MobileUno.ViewModels;

public class MainViewModel
{
	public MainViewModel()
	{
		var season = DateTime.Now.GetSeason();
		BackgroundSource = $"Assets/Images/{season.ToString().ToLower()}.jpg";

		CurrentUser = "Exempel Användare";
		CurrentCompany = "000 Exempel Företag";

		HomeItems = new ObservableCollection<HomeItem>();
	}

	public string BackgroundSource { get; }

	public string CurrentUser { get; }

	public string CurrentUserInitials => CurrentUser
		.Split(' ')
		.Aggregate(string.Empty, (s, w) => s + char.ToUpper(w[0]));

	public string CurrentCompany { get; }

	public ObservableCollection<HomeItem> HomeItems { get; }
}