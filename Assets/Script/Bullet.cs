using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	Rigidbody bulletRigid;
	Transform bulletTrans;

	[SerializeField]
	int bulletspeed;

	int ctr = 0;

	// Use this for initialization
	void Start () {
		bulletTrans = GetComponent<Transform> ();
		bulletRigid = GetComponent<Rigidbody> ();
		bulletRigid.AddForce(bulletTrans.TransformDirection (Vector3.forward * bulletspeed));


	}

	// Update is called once per frame
	void Update () {

		if(!bulletRigid.isKinematic && !UI.checkPause)
		{

			if (ctr >= 140) {
				bulletRigid.isKinematic = true;
				Destroy (gameObject);
				ctr = 0;
		
			}
			ctr++;
		}


	}

	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "Player") {
			Destroy (gameObject);
		}


	}
}
