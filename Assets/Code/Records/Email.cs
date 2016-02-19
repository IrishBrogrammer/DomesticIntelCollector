using UnityEngine;
using System.Collections;

// Class to represent an email.
[System.Serializable]
public class Email 
{
	public string From;
	public string To;
	public string Content;
	public bool   IsRead;
}
