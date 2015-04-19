using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	public Vector3 Impulse;
	public Vector3 PlayerVelY;
	public Vector3 PlayerTwoVelY;

	float velx;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(Impulse, ForceMode.Impulse);

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision Info) {
		if(Info.collider.tag == "PlayerOne") {

			velx = GetComponent<Rigidbody>().velocity.x;
			velx = velx/2 + Info.collider.attachedRigidbody.velocity.x/3;

			GetComponent<Rigidbody>().AddForce(PlayerVelY, ForceMode.Impulse);

		}

		if(Info.collider.tag == "PlayerTwo") {
			
			velx = GetComponent<Rigidbody>().velocity.x;
			velx = velx/2 + Info.collider.attachedRigidbody.velocity.x/3;
			
			GetComponent<Rigidbody>().AddForce(PlayerTwoVelY, ForceMode.Impulse);
			
		}
	}
}
