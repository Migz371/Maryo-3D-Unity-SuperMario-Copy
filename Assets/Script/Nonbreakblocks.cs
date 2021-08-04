using UnityEngine;
using System.Collections;

public class Nonbreakblocks : MonoBehaviour {

	[SerializeField]
	GameObject expPrefab;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{

		//Normal

		if (col.collider.tag == "Player" && Player.isBig) {

			SoundManager.breakblock.Play ();
			Instantiate (expPrefab, GetComponent<Transform> ().position, Quaternion.identity);
			Destroy (gameObject);

		}


	}
}
