using UnityEngine;
using System.Collections;

public class ButtonSet : MonoBehaviour {

	public void StartAnimate(){
		GetComponent<Animation>().Play ();
	}

	public void StopAnimate(){
	}

}
