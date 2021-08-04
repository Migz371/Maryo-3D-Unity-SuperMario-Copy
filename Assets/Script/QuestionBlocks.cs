using UnityEngine;
using System.Collections;

public class QuestionBlocks : MonoBehaviour {



	public GameObject pickupPrefab;
	public GameObject pickupPrefab2;
	public Material usedMat;

	void HitZone(){

		if (Player.isBig) {
			Instantiate (pickupPrefab2, transform.position + Vector3.up, transform.rotation);
		} else {

			Instantiate (pickupPrefab, transform.position + Vector3.up, transform.rotation);

		}

		SoundManager.powerupappear.Play ();
		transform.GetComponent<Renderer> ().material = usedMat;
		GetComponent<BoxCollider> ().enabled = false;
	}



//	private void OnTriggerEnter(Collider other)
//	{
//		if (other.tag == "Player") {
//			HitZone ();
//
//		}
//	}


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


