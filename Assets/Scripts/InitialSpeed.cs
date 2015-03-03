using UnityEngine;
using System.Collections;

public class InitialSpeed : MonoBehaviour {

	public float initialForce = 10;
	public float direction = 1;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(Vector3.forward*direction * initialForce);
	}
	

}
