using UnityEngine;
using System.Collections;

public class Crown : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Player.isFireFlower) {
			transform.GetChild (0).gameObject.SetActive (true);
		} else if(!Player.isFireFlower){
			transform.GetChild (0).gameObject.SetActive (false);

		}



	}
}
