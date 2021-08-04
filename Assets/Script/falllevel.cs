using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class falllevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision col)
	{



		if (col.collider.tag == "Player") {
			Player.templife--;
			Player.life--;
			SceneManager.LoadScene (1);
		}



}

}



