using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	float speed = 10f;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	

		if(Input.GetKey(KeyCode.A)) {
			rb.velocity = new Vector3(speed * -1, 0, 0);
		} else if(Input.GetKey(KeyCode.D)) {
			rb.velocity = new Vector3(speed, 0, 0);
		} else {
			rb.velocity = new Vector3(0, 0, 0);
		}

	}
}
