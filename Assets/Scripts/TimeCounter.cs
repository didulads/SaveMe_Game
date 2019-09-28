using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeCounter : MonoBehaviour {

	public Text clock;
	private float time;

	public void Start(){
		time = 125f;
		clock.text = ""+(int)time;
	}

	public void Update(){
		time = time - Time.deltaTime;
		if ((int)time > 0) {
			clock.text = "" + (int)time;
		} else {
			clock.text = "00";
		}
	}
}
