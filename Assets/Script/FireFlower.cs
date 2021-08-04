using UnityEngine;
using System.Collections;

public class FireFlower : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {



	}


	void OnCollisionEnter(Collision col)
	{

		//Normal

		if (col.collider.tag == "Player") {
			if (Player.isFireFlower) {
				Player.score += 150;
			}


			SoundManager.getpowerup.Play ();
			Player.isFireFlower = true;
			Destroy (gameObject);

	

		}


	}
}
