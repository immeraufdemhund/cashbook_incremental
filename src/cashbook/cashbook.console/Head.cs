using System;
using cashbook.body;
using CLAP;

namespace cashbook.console
{
	class Head {
		Body body;

		public Head(Body body) {
			this.body = body;
		}

		public void Run(string[] args) {
			Parser.Run (args, this);
		}

		[Verb(IsDefault=true)]
		void Sheet() {
			Console.WriteLine ("sheet...");
		}

		[Verb]
		void Withdraw (){
			Console.WriteLine ("withdraw...");
		}

		[Verb]
		void Deposit () {
			Console.WriteLine ("deposit...");
		}

		[Verb]
		void Export() {
			Console.WriteLine ("export...");
		}
	}
}
