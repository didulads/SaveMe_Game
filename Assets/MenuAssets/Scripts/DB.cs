using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Networking;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Networking;

public class DB : MonoBehaviour {
	ItemPurchaseValues res;
	void Start() { }

	public IEnumerator GETS(string url)
	{
		UnityWebRequest www = new UnityWebRequest(url);
		yield return www.Send ();

		if (www.isNetworkError) {
			Debug.Log ("WWW Error: " + www.error);
		} else {
			Debug.Log("WWW Response: " + www.error);
		}
	}

	public WWW GET(string url)
	{
		WWW www = new WWW(url);
		StartCoroutine(WaitForRequest(www));
		return www;
	}

	private IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		// check for errors
		if (www.error == null)
		{
			res = GameObject.FindGameObjectWithTag ("Transaction").GetComponent<ItemPurchaseValues> ();
			res.resultDisplay (www);
		}
		else
		{
			Debug.Log("WWW Error: " + www.error);
		}
	}
}
