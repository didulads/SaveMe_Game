using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Instantiate : MonoBehaviour {
	private GameObject floorLimit;
	private GameObject target;
	private GameObject jeep;
	public GameObject targetFloor;
	public Sprite targetSquare;
	private int[] excludeRowF = new int[]{6,8,10,12};
	private int[] excludeColumnF = new int[]{3,3,3,3,3};
	private int[] excludeRowB = new int[]{6,8,10,12};
	private int[] excludeColumnB = new int[]{5,5,5,5,5};
	private int[] excludeRowL = new int[]{4,6,8,10,12};
	private int[] excludeColumnL = new int[]{0,0,0,0,0,0};
	private int[] excludeRowR = new int[]{4,6,8,10,12};
	private int[] excludeColumnR = new int[]{9,9,9,9,9,9};

	private GameObject sedanHA;
	private GameObject sedanFM;
	private GameObject pickupFR;
	private GameObject suvCB;
	private GameObject wagonVV;
	private GameObject cone;


	void Start () {
		cone = GameObject.FindGameObjectWithTag ("Cone");
		target = GameObject.FindGameObjectWithTag ("TargetSet");

		//Init Practice 1
		if (PlayerPrefs.GetInt ("level") == 1) {
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (180,0,310);
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(160, 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(170, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(180, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(190, 0, 350), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 2
		if (PlayerPrefs.GetInt ("level") == 2) {
			this.GetComponent<CollitionDetect> ().direction = false;
			Quaternion rotation = Quaternion.Euler (0, 20, 0);
			target.transform.position = new Vector3 (330,0,310);
			target.transform.rotation = rotation;
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200+(i/2), 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(150+(i/2), 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(350, 0, 350), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 3
		if (PlayerPrefs.GetInt ("level") == 3) {
			this.GetComponent<CollitionDetect> ().direction = false;
			Quaternion rotation = Quaternion.Euler (0, -20, 0);
			target.transform.position = new Vector3 (25,0,310);
			target.transform.rotation = rotation;
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200-(i/2), 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(150-(i/2), 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(0, 0, 350), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 4
		if (PlayerPrefs.GetInt ("level") == 4) {
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			Quaternion rotation = Quaternion.Euler (0, 90, 0);
			target.transform.position = new Vector3 (170,0,175);
			target.transform.rotation = rotation;
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(i, 0, 150), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(i, 0, 200), Quaternion.Euler(0, 0, 0));
			}
		}

		//Init Practice 5
		if (PlayerPrefs.GetInt ("level") == 5) {
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			Quaternion rotation = Quaternion.Euler (0, 270, 0);
			target.transform.position = new Vector3 (170,0,175);
			target.transform.rotation = rotation;
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(i, 0, 150), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(i, 0, 200), Quaternion.Euler(0, 0, 0));
			}
		}

		//Init Level 1

		if (PlayerPrefs.GetInt ("level") == 6) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (8*20,0,3*40);
		} 

		//Init Level 2

		else if (PlayerPrefs.GetInt ("level") == 7) {
			basicInit (0);
			Quaternion rotation = Quaternion.Euler (0, 90, 0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (0*20,0,6*40);
			target.transform.rotation = rotation;
		}

		//Init Level 3

		else if (PlayerPrefs.GetInt ("level") == 8) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (10*20,0,5*40);
		}

		//Init Level 4

		else if (PlayerPrefs.GetInt ("level") == 9) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (12*20,0,9*40);
		}

		//Init Level 5

		else if (PlayerPrefs.GetInt ("level") == 10) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (8*20,0,3*40);
		}

		//Init Level 6

		else if (PlayerPrefs.GetInt ("level") == 11) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (10*20,0,200);
		}

		//Init Level 7

		else if (PlayerPrefs.GetInt ("level") == 12) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (10*20,0,5*40);
		}

		//Init Level 8

		else if (PlayerPrefs.GetInt ("level") == 13) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (12*20,0,9*40);
		}

		//Init Level 9

		else if (PlayerPrefs.GetInt ("level") == 14) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (12*20,0,9*40);
			var dummycar1 = GameObject.Instantiate (sedanHA, new Vector3 (12 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar2 = GameObject.Instantiate (sedanHA, new Vector3 (10 * 20, 20.9f, 3 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar3 = GameObject.Instantiate (sedanHA, new Vector3 (0 * 20, 20.9f, 4 * 40), Quaternion.Euler (0, 90, 0));
			var dummycar4 = GameObject.Instantiate (pickupFR, new Vector3 (14 * 20, 0, 9 * 40), Quaternion.Euler (0, 0, 0));
		}

		//Init Level 10

		else if (PlayerPrefs.GetInt ("level") == 15) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (0*20,0,6*40);
			target.transform.rotation = Quaternion.Euler (0, 90, 0);
			var dummycar1 = GameObject.Instantiate (suvCB, new Vector3 (7 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 180, 0));
			var dummycar2 = GameObject.Instantiate (wagonVV, new Vector3 (9 * 20, 20.9f, 3 * 40), Quaternion.Euler (0, 180, 0));
			var dummycar3 = GameObject.Instantiate (sedanHA, new Vector3 (0 * 20, 20.9f, 4 * 40), Quaternion.Euler (0, 90, 0));
			var dummycar4 = GameObject.Instantiate (pickupFR, new Vector3 (10 * 20, 0, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar5 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 8.3f * 40), Quaternion.Euler (0, -90, 0));
			var dummycar6 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 30), Quaternion.Euler (0, 90, 0));
		}

		//Init Level 11

		else if (PlayerPrefs.GetInt ("level") == 16) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (4.6f*20,0,20);
			target.transform.rotation = Quaternion.Euler (0, 0, 0);
			var dummycar1 = GameObject.Instantiate (suvCB, new Vector3 (9 * 20, 20.9f, 3 * 40), Quaternion.Euler (0, 180, 0));
			var dummycar2 = GameObject.Instantiate (wagonVV, new Vector3 (4 * 20, 20.9f, 20), Quaternion.Euler (0, 180, 0));
			var dummycar3 = GameObject.Instantiate (sedanHA, new Vector3 (8 * 20, 20.9f, 20), Quaternion.Euler (0, 0, 0));
			var dummycar4 = GameObject.Instantiate (pickupFR, new Vector3 (10 * 20, 0, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar5 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 8.3f * 40), Quaternion.Euler (0, -90, 0));
			var dummycar6 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 30), Quaternion.Euler (0, 90, 0));
			var dummycar7 = GameObject.Instantiate (sedanHA, new Vector3 (14 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar8 = GameObject.Instantiate (suvCB, new Vector3 (15 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 180, 0));
		}

		//Init Level 12

		else if (PlayerPrefs.GetInt ("level") == 17) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (6*20,0,200);
			target.transform.rotation = Quaternion.Euler (0, 0, 0);
			var dummycar1 = GameObject.Instantiate (suvCB, new Vector3 (9 * 20, 20.9f, 3 * 40), Quaternion.Euler (0, 180, 0));
			var dummycar2 = GameObject.Instantiate (wagonVV, new Vector3 (0, 20.9f, 180), Quaternion.Euler (0, 90, 0));
			var dummycar3 = GameObject.Instantiate (sedanHA, new Vector3 (0, 20.9f, 276), Quaternion.Euler (0, -90, 0));
			var dummycar4 = GameObject.Instantiate (pickupFR, new Vector3 (10 * 20, 0, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar5 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 8.3f * 40), Quaternion.Euler (0, -90, 0));
			var dummycar6 = GameObject.Instantiate (sedanFM, new Vector3 (18 * 20, 0, 30), Quaternion.Euler (0, 90, 0));
			var dummycar7 = GameObject.Instantiate (sedanHA, new Vector3 (14 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar8 = GameObject.Instantiate (suvCB, new Vector3 (15 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 180, 0));
		}

		//Init Level 13

		else if (PlayerPrefs.GetInt ("level") == 18) {
			basicInit (0);
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (10*20,0,200);
			target.transform.rotation = Quaternion.Euler (0, 0, 0);
			var dummycar1 = GameObject.Instantiate (suvCB, new Vector3 (145, 20.9f, 200), Quaternion.Euler (0, 180, 0));
			var dummycar2 = GameObject.Instantiate (wagonVV, new Vector3 (140, 20.9f, 200), Quaternion.Euler (0, 0, 0));
			var dummycar3 = GameObject.Instantiate (jeep, new Vector3 (280, 0, 200), Quaternion.Euler (0, 0, 0));
			var dummycar4 = GameObject.Instantiate (pickupFR, new Vector3 (10 * 20, 0, 9 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar5 = GameObject.Instantiate (jeep, new Vector3 (9 * 20, 0, 3 * 40), Quaternion.Euler (0, 180, 0));
			var dummycar6 = GameObject.Instantiate (sedanFM, new Vector3 (120, 0, 130), Quaternion.Euler (0, 90, 0));
			var dummycar7 = GameObject.Instantiate (sedanHA, new Vector3 (13 * 20, 20.9f, 3 * 40), Quaternion.Euler (0, 0, 0));
			var dummycar8 = GameObject.Instantiate (suvCB, new Vector3 (15 * 20, 20.9f, 9 * 40), Quaternion.Euler (0, 180, 0));
		}

        //Init Level 14

        else if (PlayerPrefs.GetInt("level") == 19)
        {
            basicInit(0);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(360, 0, 120);
            target.transform.rotation = Quaternion.Euler(0, 90, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(160, 0, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(0, 0, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(360, 0, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(120, 0, 3 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 15

        else if (PlayerPrefs.GetInt("level") == 20)
        {
            basicInit(0);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(340, 0, 360);
            target.transform.rotation = Quaternion.Euler(0, 45, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(100, 20.9f, 120), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(360, 0, 270), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(160, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(240, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(250, 0,200), Quaternion.Euler(0, 0, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f,100), Quaternion.Euler(0, 90, 0));
            var dummycar9 = GameObject.Instantiate(sedanFM, new Vector3(4, 0, 70), Quaternion.Euler(0, 90, 0));
            var dummycar10 = GameObject.Instantiate(sedanHA, new Vector3(320, 20.9f,360), Quaternion.Euler(0, 0, 0));
            var dummycar11 = GameObject.Instantiate(sedanHA, new Vector3(280, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar12 = GameObject.Instantiate(sedanHA, new Vector3(240, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar13 = GameObject.Instantiate(sedanHA, new Vector3(200, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar14 = GameObject.Instantiate(sedanFM, new Vector3(330, 0, 115), Quaternion.Euler(0, 0, 0));
        }

        //Init Level 16

        else if (PlayerPrefs.GetInt("level") == 21)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(0 * 20, 0, 6 * 40);
            target.transform.rotation = Quaternion.Euler(0, 270, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(7 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 20.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
        }

        //Init Level 17

        else if (PlayerPrefs.GetInt("level") == 22)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(4.6f * 20, 0, 20);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(4 * 20, 20.9f, 20), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(8 * 20, 20.9f, 20), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 18

        else if (PlayerPrefs.GetInt("level") == 23)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(6 * 20, 0, 200);
            target.transform.rotation = Quaternion.Euler(0, 180, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(0, 20.9f, 180), Quaternion.Euler(0, 90, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0, 20.9f, 276), Quaternion.Euler(0, -90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 19

        else if (PlayerPrefs.GetInt("level") == 24)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(10 * 20, 0, 200);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(145, 20.9f, 200), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 200), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(280, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(9 * 20, 0, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(120, 0, 130), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(13 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 20

        else if (PlayerPrefs.GetInt("level") == 25)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(360, 0, 120);
            target.transform.rotation = Quaternion.Euler(0, 270, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(160, 0, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(0, 0, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(360, 0, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(120, 0, 3 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

		//Init Practice 6
		if (PlayerPrefs.GetInt ("level") == 26) {
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (225,0,80);
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(150, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(250, 0, i), Quaternion.Euler(0, 0, 0));
			}
			for (int i = 50; i < 311; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(170, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(200, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(230, 0, 350), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 7
		if (PlayerPrefs.GetInt ("level") == 27) {
			this.GetComponent<CollitionDetect> ().direction = false;
			target.transform.position = new Vector3 (125,0,90);
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(100, 0, i), Quaternion.Euler(0, 0, 0));
			}
			for (int i = 50; i < 311; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(150, 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(120, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(150, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(180, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone6 = GameObject.Instantiate(cone, new Vector3(125, 0, 50), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 8
		if (PlayerPrefs.GetInt ("level") == 28) {
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (225,0,90);
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(150, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(250, 0, i), Quaternion.Euler(0, 0, 0));
			}
			for (int i = 50; i < 311; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(170, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(200, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(230, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone6 = GameObject.Instantiate(cone, new Vector3(225, 0, 50), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 9
		if (PlayerPrefs.GetInt ("level") == 29) {
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			target.transform.position = new Vector3 (125,0,90);
			for (int i = 50; i < 351; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(100, 0, i), Quaternion.Euler(0, 0, 0));
			}
			for (int i = 50; i < 311; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(150, 0, i), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(120, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(150, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(180, 0, 350), Quaternion.Euler(0, 0, 0));
			var dummycone6 = GameObject.Instantiate(cone, new Vector3(125, 0, 50), Quaternion.Euler(0, 0, 0));
		}

		//Init Practice 10
		if (PlayerPrefs.GetInt ("level") == 30) {
			this.GetComponent<CollitionDetect> ().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
			Quaternion rotation = Quaternion.Euler(0, 90, 0);
			target.transform.position = new Vector3 (340,0,250);
			target.transform.rotation = rotation;
			for (int i = 50; i < 231; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(200, 0, i), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(160, 0, i), Quaternion.Euler(0, 0, 0));
			}

			for (int i = 230; i < 381; i = i + 30) {
				var dummycone1 = GameObject.Instantiate(cone, new Vector3(i, 0, 270), Quaternion.Euler(0, 0, 0));
				var dummycone2 = GameObject.Instantiate(cone, new Vector3(i, 0, 230), Quaternion.Euler(0, 0, 0));
			}
			var dummycone3 = GameObject.Instantiate(cone, new Vector3(200, 0, 270), Quaternion.Euler(0, 0, 0));
			var dummycone4 = GameObject.Instantiate(cone, new Vector3(160, 0, 270), Quaternion.Euler(0, 0, 0));
			var dummycone5 = GameObject.Instantiate(cone, new Vector3(180, 0, 270), Quaternion.Euler(0, 0, 0));
		}

        //Init Level 21

        else if (PlayerPrefs.GetInt("level") == 31)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(8 * 20, 50, 3 * 40);
        }

        //Init Level 22

        else if (PlayerPrefs.GetInt("level") == 32)
        {
            basicInit(0);
            basicInit(50);
            Quaternion rotation = Quaternion.Euler(0, 90, 0);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(0 * 20, 50, 6 * 40);
            target.transform.rotation = rotation;
        }

        //Init Level 23

        else if (PlayerPrefs.GetInt("level") == 33)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(10 * 20, 50, 5 * 40);
        }

        //Init Level 24

        else if (PlayerPrefs.GetInt("level") == 34)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(12 * 20, 50, 9 * 40);
        }

        //Init Level 25

        else if (PlayerPrefs.GetInt("level") == 35)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = true;
            targetFloor.GetComponent<SpriteRenderer>().sprite = targetSquare;
            target.transform.position = new Vector3(8 * 20, 50, 3 * 40);
        }

        //Init Level 26

        else if (PlayerPrefs.GetInt("level") == 36)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = true;
            targetFloor.GetComponent<SpriteRenderer>().sprite = targetSquare;
            target.transform.position = new Vector3(10 * 20, 50,2 * 40);
        }

        //Init Level 27

        else if (PlayerPrefs.GetInt("level") == 37)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = true;
            targetFloor.GetComponent<SpriteRenderer>().sprite = targetSquare;
            target.transform.position = new Vector3(10 * 20, 50, 5 * 40);
        }

        //Init Level 28

        else if (PlayerPrefs.GetInt("level") == 38)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = true;
            targetFloor.GetComponent<SpriteRenderer>().sprite = targetSquare;
            target.transform.position = new Vector3(12 * 20, 50, 9 * 40);
        }

        //Init Level 29

        else if (PlayerPrefs.GetInt("level") == 39)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(12 * 20, 50, 9 * 40);
            var dummycar1 = GameObject.Instantiate(sedanHA, new Vector3(12 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar2 = GameObject.Instantiate(sedanHA, new Vector3(10 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 20.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(14 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanHA, new Vector3(12 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar6 = GameObject.Instantiate(sedanHA, new Vector3(10 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 70.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar8 = GameObject.Instantiate(pickupFR, new Vector3(14 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
        }

        //Init Level 30

        else if (PlayerPrefs.GetInt("level") == 40)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(0 * 20, 50, 160);
            target.transform.rotation = Quaternion.Euler(0, 90, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(7 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 20.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar8 = GameObject.Instantiate(wagonVV, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar9 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 70.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar10 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar11 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar12 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 30), Quaternion.Euler(0, 90, 0));
        }

        //Init Level 31

        else if (PlayerPrefs.GetInt("level") == 41)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(4.6f * 20, 50, 20);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(4 * 20, 20.9f, 20), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(8 * 20, 20.9f, 20), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar9 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar10 = GameObject.Instantiate(wagonVV, new Vector3(4 * 20, 70.9f, 20), Quaternion.Euler(0, 180, 0));
            var dummycar11 = GameObject.Instantiate(sedanHA, new Vector3(8 * 20, 70.9f, 20), Quaternion.Euler(0, 0, 0));
            var dummycar12 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar13 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar14 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 30), Quaternion.Euler(0, 90, 0));
            var dummycar15 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar16 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 32

        else if (PlayerPrefs.GetInt("level") == 42)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(6 * 20, 50, 200);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(0, 20.9f, 180), Quaternion.Euler(0, 90, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0, 20.9f, 276), Quaternion.Euler(0, -90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(0, 70.9f, 180), Quaternion.Euler(0, 90, 0));
            var dummycar3b = GameObject.Instantiate(sedanHA, new Vector3(0, 70.9f, 276), Quaternion.Euler(0, -90, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5b = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6b = GameObject.Instantiate(sedanFM, new Vector3(18 * 20,50, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 33

        else if (PlayerPrefs.GetInt("level") == 43)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(10 * 20, 50, 200);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(145, 20.9f, 200), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 200), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(280, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(9 * 20, 0, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(13 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(145, 70.9f, 200), Quaternion.Euler(0, 180, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(140, 70.9f, 200), Quaternion.Euler(0, 0, 0));
            var dummycar3b = GameObject.Instantiate(jeep, new Vector3(280, 50, 200), Quaternion.Euler(0, 0, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5b = GameObject.Instantiate(jeep, new Vector3(9 * 20, 50, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(13 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 34

        else if (PlayerPrefs.GetInt("level") == 44)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(360, 50, 120);
            target.transform.rotation = Quaternion.Euler(0, 90, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(160, 0, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(0, 0, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(360, 0, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(360, 70.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(140, 70.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3b = GameObject.Instantiate(jeep, new Vector3(160, 50, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(0, 50, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5b = GameObject.Instantiate(jeep, new Vector3(360, 50, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(275, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 35

        else if (PlayerPrefs.GetInt("level") == 45)
        {
            basicInit(0);
            basicInit(50);
            this.GetComponent<CollitionDetect>().direction = false;
            target.transform.position = new Vector3(340, 50, 360);
            target.transform.rotation = Quaternion.Euler(0, 45, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(100, 20.9f, 120), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(360, 0, 270), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(160, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(240, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(250, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 100), Quaternion.Euler(0, 90, 0));
            var dummycar9 = GameObject.Instantiate(sedanFM, new Vector3(4, 0, 70), Quaternion.Euler(0, 90, 0));
            var dummycar10 = GameObject.Instantiate(sedanHA, new Vector3(320, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar11 = GameObject.Instantiate(sedanHA, new Vector3(280, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar12 = GameObject.Instantiate(sedanHA, new Vector3(240, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar13 = GameObject.Instantiate(sedanHA, new Vector3(200, 20.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar14 = GameObject.Instantiate(sedanFM, new Vector3(330, 0, 115), Quaternion.Euler(0, 0, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(360, 70.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(100, 70.9f, 120), Quaternion.Euler(0, 0, 0));
            var dummycar3b = GameObject.Instantiate(jeep, new Vector3(360, 50, 270), Quaternion.Euler(0, 90, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(160, 50, 200), Quaternion.Euler(0, 0, 0));
            var dummycar5b = GameObject.Instantiate(jeep, new Vector3(240, 50, 200), Quaternion.Euler(0, 0, 0));
            var dummycar6b = GameObject.Instantiate(sedanFM, new Vector3(250, 50, 200), Quaternion.Euler(0, 0, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(275, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(360, 70.9f, 100), Quaternion.Euler(0, 90, 0));
            var dummycar9b = GameObject.Instantiate(sedanFM, new Vector3(4, 50, 70), Quaternion.Euler(0, 90, 0));
            var dummycar10b = GameObject.Instantiate(sedanHA, new Vector3(320, 70.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar11b = GameObject.Instantiate(sedanHA, new Vector3(280, 70.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar12b = GameObject.Instantiate(sedanHA, new Vector3(240, 70.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar13b = GameObject.Instantiate(sedanHA, new Vector3(200, 70.9f, 360), Quaternion.Euler(0, 0, 0));
            var dummycar14b = GameObject.Instantiate(sedanFM, new Vector3(330, 50, 115), Quaternion.Euler(0, 0, 0));
        }

        //Init Level 36

        else if (PlayerPrefs.GetInt("level") == 46)
        {
            basicInit(0);
            basicInit(50);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(0 * 20, 50, 4 * 40);
            target.transform.rotation = Quaternion.Euler(0, 270, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(7 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 20.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar8 = GameObject.Instantiate(wagonVV, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar9 = GameObject.Instantiate(sedanHA, new Vector3(0 * 20, 70.9f, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar10 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar11 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar12 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 30), Quaternion.Euler(0, 90, 0));
        }

        //Init Level 37

        else if (PlayerPrefs.GetInt("level") == 47)
        {
            basicInit(0);
            basicInit(50);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(4.6f * 20, 50, 20);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(4 * 20, 20.9f, 20), Quaternion.Euler(0, 180, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(8 * 20, 20.9f, 20), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar9 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar10 = GameObject.Instantiate(wagonVV, new Vector3(4 * 20, 70.9f, 20), Quaternion.Euler(0, 180, 0));
            var dummycar11 = GameObject.Instantiate(sedanHA, new Vector3(8 * 20, 70.9f, 20), Quaternion.Euler(0, 0, 0));
            var dummycar12 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar13 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar14 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 30), Quaternion.Euler(0, 90, 0));
            var dummycar15 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar16 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 38

        else if (PlayerPrefs.GetInt("level") == 48)
        {
            basicInit(0);
            basicInit(50);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(6 * 20, 50, 200);
            target.transform.rotation = Quaternion.Euler(0, 180, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(0, 20.9f, 180), Quaternion.Euler(0, 90, 0));
            var dummycar3 = GameObject.Instantiate(sedanHA, new Vector3(0, 20.9f, 276), Quaternion.Euler(0, -90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 0, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(9 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(0, 70.9f, 180), Quaternion.Euler(0, 90, 0));
            var dummycar3b = GameObject.Instantiate(sedanHA, new Vector3(-25f, 70.9f, 276), Quaternion.Euler(0, -90, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5b = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 8.3f * 40), Quaternion.Euler(0, -90, 0));
            var dummycar6b = GameObject.Instantiate(sedanFM, new Vector3(18 * 20, 50, 30), Quaternion.Euler(0, 90, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(14 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 39

        else if (PlayerPrefs.GetInt("level") == 49)
        {
            basicInit(0);
            basicInit(50);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(10 * 20, 50, 200);
            target.transform.rotation = Quaternion.Euler(0, 0, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(145, 20.9f, 200), Quaternion.Euler(0, 180, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 200), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(280, 0, 200), Quaternion.Euler(0, 0, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 0, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(9 * 20, 0, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(13 * 20, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(145, 70.9f, 200), Quaternion.Euler(0, 180, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(140, 70.9f, 200), Quaternion.Euler(0, 0, 0));
            var dummycar3b = GameObject.Instantiate(jeep, new Vector3(280, 50, 200), Quaternion.Euler(0, 0, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(10 * 20, 50, 9 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar5b = GameObject.Instantiate(jeep, new Vector3(9 * 20, 50, 3 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(13 * 20, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }

        //Init Level 40

        else if (PlayerPrefs.GetInt("level") == 50)
        {
            basicInit(0);
			this.GetComponent<CollitionDetect>().direction = true;
			targetFloor.GetComponent<SpriteRenderer> ().sprite = targetSquare;
            target.transform.position = new Vector3(360, 50, 120);
            target.transform.rotation = Quaternion.Euler(0, 270, 0);
            var dummycar1 = GameObject.Instantiate(suvCB, new Vector3(360, 20.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2 = GameObject.Instantiate(wagonVV, new Vector3(140, 20.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3 = GameObject.Instantiate(jeep, new Vector3(160, 0, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4 = GameObject.Instantiate(pickupFR, new Vector3(0, 0, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5 = GameObject.Instantiate(jeep, new Vector3(360, 0, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar6 = GameObject.Instantiate(sedanFM, new Vector3(120, 0, 9 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7 = GameObject.Instantiate(sedanHA, new Vector3(275, 20.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8 = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 20.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
            var dummycar1b = GameObject.Instantiate(suvCB, new Vector3(360, 70.9f, 200), Quaternion.Euler(0, -90, 0));
            var dummycar2b = GameObject.Instantiate(wagonVV, new Vector3(140, 70.9f, 100), Quaternion.Euler(0, 0, 0));
            var dummycar3b = GameObject.Instantiate(jeep, new Vector3(160, 50, 200), Quaternion.Euler(0, 90, 0));
            var dummycar4b = GameObject.Instantiate(pickupFR, new Vector3(0, 50, 120), Quaternion.Euler(0, 90, 0));
            var dummycar5b = GameObject.Instantiate(jeep, new Vector3(360, 50, 4 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar6b = GameObject.Instantiate(sedanFM, new Vector3(120, 50, 9 * 40), Quaternion.Euler(0, 90, 0));
            var dummycar7b = GameObject.Instantiate(sedanHA, new Vector3(275, 70.9f, 3 * 40), Quaternion.Euler(0, 0, 0));
            var dummycar8b = GameObject.Instantiate(suvCB, new Vector3(15 * 20, 70.9f, 9 * 40), Quaternion.Euler(0, 180, 0));
        }


    }

    private void basicInit(int height){
		//Init the basic

		sedanHA = GameObject.FindGameObjectWithTag ("SedanHA");
		sedanFM = GameObject.FindGameObjectWithTag ("SedanFM");
		pickupFR = GameObject.FindGameObjectWithTag ("PickupFR");
		wagonVV = GameObject.FindGameObjectWithTag ("WagonVV");
		suvCB = GameObject.FindGameObjectWithTag ("SUVCB");
		jeep = GameObject.FindGameObjectWithTag ("Jeep");

		//ground barricade front
		for (int x = 0; x < excludeRowF.Length; x++) {
			Quaternion rotation = Quaternion.Euler (0, 0, 0);
			floorLimit = GameObject.FindWithTag ("Barricade");
			var block = GameObject.Instantiate (floorLimit, new Vector3 ((excludeRowF [x] * 20), height, (excludeColumnF [x] * 40)), rotation);
		}
		//ground barricade back
		for (int x = 0; x < excludeRowB.Length; x++) {
			Quaternion rotation = Quaternion.Euler (0, 180, 0);
			floorLimit = GameObject.FindWithTag ("Barricade");
			var block = GameObject.Instantiate (floorLimit, new Vector3 ((excludeRowB [x] * 20), height, (excludeColumnB [x] * 40)), rotation);
		}
        //ground left
        if (height == 0) { 
		for (int x = 0; x < excludeRowL.Length; x++) {
			Quaternion rotation = Quaternion.Euler (0, 90, 0);
			floorLimit = GameObject.FindWithTag ("Finish");
			var block = GameObject.Instantiate (floorLimit, new Vector3 ((excludeColumnL [x] * 40), height, (excludeRowL [x] * 20)), rotation);
		}
        }else
        {
            for (int x = 0; x < (excludeRowL.Length-1); x++)
            {
                Quaternion rotation = Quaternion.Euler(0, 90, 0);
                floorLimit = GameObject.FindWithTag("Finish");
                var block = GameObject.Instantiate(floorLimit, new Vector3((excludeColumnL[x] * 40), height, (excludeRowL[x] * 20)), rotation);
            }
        }
		//ground right
		for (int x = 0; x < excludeRowR.Length; x++) {
			Quaternion rotation = Quaternion.Euler (0, 90, 0);
			floorLimit = GameObject.FindWithTag ("Finish");
			var block = GameObject.Instantiate (floorLimit, new Vector3 ((excludeColumnR [x] * 40), height, (excludeRowR [x] * 20)), rotation);
		}
		//ground front
		int m = 16;
		for (int x = 0; x < 5; x++) {
			Quaternion rotation = Quaternion.Euler (0, 0, 0);
			floorLimit = GameObject.FindWithTag ("Finish");
			var block = GameObject.Instantiate (floorLimit, new Vector3 ((m * 20), height, (9 * 40)), rotation);
			m = m - 2;
		}
	}
}