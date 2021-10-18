using System;
using MobileUno.Extensions;

namespace MobileUno.ViewModels
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			var season = DateTime.Now.GetSeason();
			BackgroundSource = $"Assets/Images/{season.ToString().ToLower()}.jpg";
		}

		public string BackgroundSource { get; }
	}
}