using UnityEngine;
using System.Collections;

public class Logic : MonoBehaviour 
{
	public TextAsset DebugText;
	private Actor prog  = null;

	// Use this for initialization
	void Start () 
	{
		Debug.Log(DebugText.text);
		var test = fastJSON.JSON.ToObject<Actor>(DebugText.text);

		foreach( var email in test.Emails )
		{
			PrintEmail( email );
		}
	
	}


	void PrintEmail(Email email)
	{
		Test(email.From, email.To, email.Content);
	}

	void Test(string from, string to, string content)
	{
		Log(" From : " + from);
		Log(" To : " + to);
		Log(content);
	}

	void Log(string output)
	{
		Debug.Log(output);
	}


}
