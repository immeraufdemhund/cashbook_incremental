using System;
using eventstore.contract;
using eventstore.internals;
using System.Collections.Generic;

namespace cashbook.body.data
{
	public class Transaction {
		public TransactionTypes Type;
		public DateTime TransactionDate;
		public decimal Amount;
		public decimal Value { get { return Type == TransactionTypes.Deposit ? Amount : -Amount; } }
		public string Description;
	}	
}