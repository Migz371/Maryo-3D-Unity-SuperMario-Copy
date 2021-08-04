using UnityEngine;
using System.Collections;

public class Mushroom : MonoBehaviour {

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

			SoundManager.getpowerup.Play ();
			Player.isBig = true;
			Destroy (gameObject);

		
			if (Player.isFireFlower){
				Player.score += 150;

			}
			
		}


	}
}
