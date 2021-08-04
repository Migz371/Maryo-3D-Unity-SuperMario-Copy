using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {


	Rigidbody expRigid;
	int ctr = 0;

	// Use this for initialization
	void Start () {
		expRigid = GetComponent<Rigidbody> ();

	}

	// Update is called once per frame
	void Update () {

		if(!expRigid.isKinematic)
		{

			if (ctr >= 90) {
				expRigid.isKinematic = true;
				Destroy (gameObject);
				ctr = 0;
			}
			ctr++;
		}

	}
}
