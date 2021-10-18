using System;
using MobileUno.Extensions;

namespace MobileUno.ViewModels
{
	public class MainViewModel
	{
		public MainViewModel()
		{
			BackgroundSource = $"Assets/Images/{DateTime.Now.GetSeason().ToString().ToLower()}.jpg";
		}

		public string BackgroundSource { get; }
	}
}