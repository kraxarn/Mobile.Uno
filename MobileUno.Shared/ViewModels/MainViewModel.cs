using System;
using System.Linq;
using MobileUno.Extensions;

namespace MobileUno.ViewModels;

public class MainViewModel
{
	public MainViewModel()
	{
		var season = DateTime.Now.GetSeason();
		BackgroundSource = $"Assets/Images/{season.ToString().ToLower()}.jpg";
	}

	public string BackgroundSource { get; }

	public string CurrentUser => "Sample User";

	public string CurrentUserInitials => CurrentUser
		.Split(' ')
		.Aggregate(string.Empty, (s, w) => s + char.ToUpper(w[0]));

	public string CurrentCompany => "000 Sample Company";
}