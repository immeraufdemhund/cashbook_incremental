using System;
using System.Collections.Generic;

namespace cashbook.body
{
	public static class CashbookExtensions {
		public static DateTime ToMonth(this DateTime date) {
			return new DateTime (date.Year, date.Month, 1);
		}


		public static DateTime[] ExtendTo(this DateTime fromMonth, DateTime toMonth) {
			if (toMonth == DateTime.MinValue) toMonth = fromMonth;
			fromMonth = fromMonth.ToMonth ();
			toMonth = toMonth.ToMonth ();

			if (toMonth < fromMonth) {
				var t = toMonth;
				toMonth = fromMonth;
				fromMonth = t;
			}

			var months = new List<DateTime> ();
			var currMonth = fromMonth;
			while (currMonth <= toMonth) {
				months.Add (currMonth);
				currMonth = currMonth.AddMonths (1);
			}

			return months.ToArray ();
		}
	}
}