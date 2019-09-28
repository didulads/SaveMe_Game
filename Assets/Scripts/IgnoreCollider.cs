using UnityEngine;
using System.Collections;

public class IgnoreCollider : MonoBehaviour {
	public GameObject stairs;
	public GameObject secondfloor;
	void Start () {
		Physics.IgnoreCollision (stairs.GetComponent<Collider>(),GetComponent<Collider>());
		Physics.IgnoreCollision (secondfloor.GetComponent<Collider>(),GetComponent<Collider>());
	}

}
