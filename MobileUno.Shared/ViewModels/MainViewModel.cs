using System;
using MobileUno.Extensions;

namespace MobileUno.ViewModels
{
	public class MainViewModel
	{
		public string BackgroundSource =>
			$"Assets/Images/{DateTime.Now.GetSeason().ToString().ToLower()}.jpg";
	}
}