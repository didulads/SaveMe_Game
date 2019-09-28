using UnityEngine;
using System.Collections;

public class Menus : MonoBehaviour {
	private Animator _animator;

	public bool IsOpen{
		get{ return _animator.GetBool ("IsOpen");}
		set{ _animator.SetBool ("IsOpen", value);}
	}

	public void Awake(){
		_animator = GetComponent<Animator> ();
	}
}
