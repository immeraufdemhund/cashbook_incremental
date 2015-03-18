using cashbook.contracts.data;
using System.Collections.Generic;
using System.IO;

namespace cashbook.body
{

	public class CSVProvider {
		public void Export(IEnumerable<BalanceSheet.Item> items, string filepath) {
			using(var sw = new StreamWriter(filepath)) {
				foreach(var item in items)
					sw.WriteLine("{0:d};\"{1}\";{2:f}", item.TransactionDate, item.Description, item.Value);
			}
		}
	}
}