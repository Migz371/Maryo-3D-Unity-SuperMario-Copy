using UnityEngine;
using System.Collections;

public class FireBallBullet : MonoBehaviour {

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

			if (ctr >= 100) {
				bulletRigid.isKinematic = true;
				Destroy (gameObject);
				ctr = 0;
				FireBall.fireBallCtr--;
			}
			ctr++;
		}


	}

	void OnCollisionEnter(Collision col){
		if (col.collider.tag == "T") {
			FireBall.fireBallCtr--;
			Destroy (gameObject);
		}


	}
}
