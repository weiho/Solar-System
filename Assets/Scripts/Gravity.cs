using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

	private float gravity = 6.67e-11f;
	public float gravityFactor = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		Rigidbody[] rigidBodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

		foreach (Rigidbody body in rigidBodies) {
			if (transform.position == body.transform.position) continue;
			//print (body);
			Vector3 bodyDistance = transform.position - body.transform.position;

			float force = gravity*gravityFactor * (rigidbody.mass * body.rigidbody.mass)/(bodyDistance.magnitude * bodyDistance.magnitude);
			//print(force);
			body.rigidbody.AddForce(bodyDistance.normalized * force);
		}
	}
}



