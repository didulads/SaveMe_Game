using UnityEngine;
using System.Collections;

public class CarTurn : MonoBehaviour {

	public WheelCollider[] wheelColliders = new WheelCollider[4];

	void FixedUpdate(){
		float steer = (gameObject.GetComponent<SteeringWheel> ().GetAngle ());
		float angle = steer / 20;
		wheelColliders [0].steerAngle = angle;
		wheelColliders [1].steerAngle = angle;
	}

}
