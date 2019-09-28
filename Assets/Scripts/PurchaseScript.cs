using UnityEngine;
using System.Collections;
using UnityEditor;

public class PurchaseScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void checker(){
		DB dB = GetComponent<DB>();
		WWW result = dB.GET ("http://localhost:8080/DANS/Admin/userupdate.php?username=admin&password=admin123&birthday=0000-01-00&mobile=0&email=&address=&gender=male&admin=1&updateuser=submit");
		Debug.Log (result);
		EditorUtility.DisplayDialog("Transaction","Item purchased","Ok","Cancel");
		Debug.Log ("Checker");
	}
}
