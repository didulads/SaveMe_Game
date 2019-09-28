using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollitionDetect : MonoBehaviour {
	public Menus gameOver;
	public Menus levelComplete;
	public Canvas canvas;
	public GameObject lev1;
	public GameObject lev2;
	public GameObject lev3;
	public GameObject crashSound;
	public Text clock;
	public bool direction;
	public Collider targetFront;
	public Collider targetBack;
	public Collider carFront;
	public Collider carBack;


	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag != "Stair" && col.gameObject.tag != "Cone" ) {
			crashSound.GetComponent<AudioSource> ().enabled = true;
			canvas.GetComponent<MenuManager> ().PauseMenu (gameOver);
		}
	}

	void FixedUpdate(){
		if (direction == true) {
			//OneWayParking
			if (targetFront.bounds.Contains (carFront.transform.position) && targetBack.bounds.Contains (carBack.transform.position)) {
				StarSetter ();
			}
		}
		if (direction == false) {
			//TwoWayParking
			if ((targetFront.bounds.Contains (carFront.transform.position) || targetFront.bounds.Contains (carBack.transform.position)) && (targetBack.bounds.Contains (carBack.transform.position) || targetBack.bounds.Contains (carFront.transform.position))) {
				StarSetter ();
			}
		}
	}

	private void StarSetter(){
		canvas.GetComponent<MenuManager> ().ShowMenu (levelComplete);
		Time.timeScale = 0;
		string prefKey = "lev"+PlayerPrefs.GetInt("level");

		if (int.Parse(clock.GetComponent<Text> ().text) >= (int)50) {
			PlayerPrefs.SetInt (prefKey,3);
			lev1.GetComponent<Animator> ().SetBool ("star1", true);
			lev2.GetComponent<Animator> ().SetBool ("star2", true);
			lev3.GetComponent<Animator> ().SetBool ("star3", true);
		}
		else if (int.Parse(clock.GetComponent<Text> ().text) >= (int)25 && int.Parse(clock.GetComponent<Text> ().text) < (int)50) {
			PlayerPrefs.SetInt (prefKey,2);
			lev1.GetComponent<Animator> ().SetBool ("star1", true);
			lev2.GetComponent<Animator> ().SetBool ("star2", true);
		}
		else if (int.Parse(clock.GetComponent<Text> ().text) >= (int)0 && int.Parse(clock.GetComponent<Text> ().text) < (int)25) {
			PlayerPrefs.SetInt (prefKey,1);
			lev1.GetComponent<Animator> ().SetBool ("star1", true);
		}
	}
}
