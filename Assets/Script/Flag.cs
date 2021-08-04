using UnityEngine;
using System.Collections;

public class Flag : MonoBehaviour {


	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision col)
	{

		//Normal

		if (col.collider.tag == "Player") {
			UI.checkLevelClear = true;
			UI.levelmusic.Stop ();
			SoundManager.win.Play ();

		}


	}
}
