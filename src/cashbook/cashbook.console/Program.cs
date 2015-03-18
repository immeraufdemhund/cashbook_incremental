using cashbook.body;
using cashbook.body.data;
using eventstore;
using System;

namespace cashbook.console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TimeProvider.Now = () => DateTime.Now;

			var es = new FileEventStore ("events");
			var repo = new Repository (es);
			var cashbookFactory = new Func<Transaction[], Cashbook>(transactions => new Cashbook (transactions));
			var csvProvider = new CSVProvider ();
			var body = new Body (repo, cashbookFactory, csvProvider);
			var head = new Head (body);

			head.Run (args);
		}
	}
}
