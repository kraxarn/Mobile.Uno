namespace MobileUno.DataTemplate;

public class HomeItem
{
	public HomeItem()
	{
	}

	public HomeItem(string description) : this()
	{
		Description = description;
	}

	public string Description { get; set; } = string.Empty;

	public string PrimaryPath { get; set; } = string.Empty;

	public string SecondaryPath { get; set; } = string.Empty;

	public double FontSize => Description.Length < 16 ? 14 : 11;
}