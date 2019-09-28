using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class ItemPurchaseValues : MonoBehaviour {
	public Text coinval;
	public Text obj;
	public Text name;
	public InputField username;
	public InputField password;
	public GameObject loginobj;
	string user = "";

	public void setcoinValue(string val){
		Debug.Log (val);
		coinval.GetComponent<Text> ().text = val;
	}
	public void setobjValue(string gameobj){
		obj.GetComponent<Text> ().text = gameobj;
	}
	public void setnameValue(string itemname){
		name.GetComponent<Text> ().text = itemname;
	}
	public void validateLogin(){
		user = username.text;
		string pw = password.text;

		DB dB = GetComponent<DB>();
		string logurl = "https://savemeapp.000webhostapp.com/Transactions/userchecker.php?userid=" + user + "&password=" + pw + "";
		WWW result = dB.GET (logurl);
		Debug.Log (user);
	}
	public void resultDisplay(WWW result){
		string res = result.text;
		Debug.Log (res);
		if (res.Equals ("UserID or Password is incorrect") || res.Equals ("Error While Login")) {
			EditorUtility.DisplayDialog ("Transaction Failed", res, "Ok", "Cancel");
		} else {
			PlayerPrefs.SetString ("Coins",res);
			PlayerPrefs.SetString ("UserId",user);
			PlayerPrefs.SetString ("GameId","0001");
			EditorUtility.DisplayDialog ("Transaction Successful", res, "Ok", "Cancel");
		}
	}
	public void purchaseitem(){
		DB dB = GetComponent<DB>();
		string url = "https://savemeapp.000webhostapp.com/Transactions/spendcoins.php?obj="+obj.GetComponent<Text> ().text+"&gameId="+PlayerPrefs.GetString("GameId")+"&playerid="+PlayerPrefs.GetString("UserId")+"";
		WWW result = dB.GET (url);
		Debug.Log (url);
	}
}
