using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	[SerializeField]
	float Xposition;

	[SerializeField]
	float Zposition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnTriggerEnter(Collider Col){
//
//		Col.transform.position = new Vector3 (Xposition, Col.transform.position.y, Zposition);	
//
//	}

	void OnCollisionEnter(Collision col)
	{

		if (col.collider.tag == "Player") {
			SoundManager.pipeenter.Play ();
				col.transform.position = new Vector3 (Xposition, col.transform.position.y, Zposition);	

		}


	}


}
