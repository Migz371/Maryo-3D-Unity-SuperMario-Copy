using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	[SerializeField]
	GameObject expPrefab;

	[SerializeField]
	GameObject bulletPrefab;

	[SerializeField]
	Transform bulletTrans;

	AudioSource turretShot;
	AudioSource explosion;






	int ctr;
	int sec;

	// Use this for initialization
	void Start () {
		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
		turretShot = allMyAudioSources [0];
		explosion = allMyAudioSources [1];
		ctr = 0;
	}

	// Update is called once per frame
	void Update () {

//		if(Input.GetButtonDown("Fire1"))
//		{
//			Instantiate (bulletPrefab, bulletTrans.position, bulletTrans.rotation);
//		}

		if (sec >= 150 && !UI.checkPause) {
			Instantiate (bulletPrefab, bulletTrans.position, bulletTrans.rotation);
			turretShot.Play ();

		
			sec = 0;
		}
		sec++;


	}

	void OnCollisionEnter(Collision col)
	{

		if (col.collider.tag == "B") {
			SoundManager.turretexplosion.Play ();
			Instantiate (expPrefab, GetComponent<Transform> ().position, Quaternion.identity);
			Player.score += 20;
			Destroy (gameObject);
	
		}

		if (col.collider.tag == "Player") {
			if (!Player.isGrounded) {
				SoundManager.turretexplosion.Play ();
				Instantiate (expPrefab, GetComponent<Transform> ().position, Quaternion.identity);
				Destroy (gameObject);
			}
		}
	}



}
