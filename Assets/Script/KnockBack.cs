using UnityEngine;
using System.Collections;

public class KnockBack : MonoBehaviour {


	private float knockbackStrength = 80;

	private void OnCollisionEnter(Collision collision){



		if (collision.collider.tag == "Player" && Player.isGrounded) {
		Rigidbody rb = collision.collider.GetComponent<Rigidbody> ();

			if (rb != null) {
				Vector3 direction = collision.transform.position - transform.position;
				direction.y = 0;

				rb.AddForce (direction.normalized * knockbackStrength, ForceMode.Impulse);
			}
		}


	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
