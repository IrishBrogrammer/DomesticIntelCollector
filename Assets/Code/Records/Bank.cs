using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BankTransaction
{
	public string TransactionId;
	public int Amount;
	public string To;
}

[System.Serializable]
public class BankRecord
{
	public int Balance;
	public List<BankTransaction> Transactions;
}
