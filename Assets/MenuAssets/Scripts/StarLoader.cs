using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarLoader : MonoBehaviour {

	public Sprite star0;
	public Sprite star1;
	public Sprite star2;
	public Sprite star3;

	void Start () {
		for (int i = 0; i < 50; i++) {
			string prefTag = "lev" + i;
			if (GameObject.Find (prefTag) != null) {
				if (PlayerPrefs.GetInt (prefTag) == 1) {
					GameObject.Find (prefTag).GetComponent<Image> ().sprite = star1;
				} else if (PlayerPrefs.GetInt (prefTag) == 2) {
					GameObject.Find (prefTag).GetComponent<Image> ().sprite = star2;
				} else if (PlayerPrefs.GetInt (prefTag) == 3) {
					GameObject.Find (prefTag).GetComponent<Image> ().sprite = star3;
				} else {
					GameObject.Find (prefTag).GetComponent<Image> ().sprite = star0;
				}
			}
		}
	}
}
