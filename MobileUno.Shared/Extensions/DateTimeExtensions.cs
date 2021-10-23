using MobileUno.Enums;
using System;

namespace MobileUno.Extensions;

public static class DateTimeExtensions
{
	public static Season GetSeason(this DateTime dateTime)
	{
		switch (dateTime.Month)
		{
			// December - February
			case >= 12:
			case <= 2:
				return Season.Winter;
			// March - May
			case >= 3 and <= 5:
				return Season.Spring;
			// June - August
			case >= 6 and <= 8:
				return Season.Summer;
			// September - November
			case >= 9 and <= 11:
				return Season.Autumn;
		}
	}
}