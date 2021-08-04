using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	int ctr = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (ctr == 70) {
			Destroy (gameObject);
			ctr = 0;
		}
		ctr++;


	}
}
