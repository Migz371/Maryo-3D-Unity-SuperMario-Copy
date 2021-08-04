using UnityEngine;
using System.Collections;

public class QuestionBlocksCoins : MonoBehaviour {



	public GameObject pickupPrefab;
	public Material usedMat;

	void HitZone(){
		Player.score += 100;
		SoundManager.coin.Play ();
		Instantiate (pickupPrefab, transform.position + Vector3.up, transform.rotation);
		transform.GetComponent<Renderer> ().material = usedMat;
		GetComponent<BoxCollider> ().enabled = false;
	}




	void OnCollisionEnter(Collision col)
	{

		if (col.collider.tag == "Player") {

			HitZone ();	

		}


	}




	// Use this for initialization
	void Start () {


	}



	// Update is called once per frame
	void Update () {



	}


}


