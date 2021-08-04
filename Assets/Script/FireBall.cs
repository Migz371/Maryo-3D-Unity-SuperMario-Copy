using UnityEngine;
using System.Collections;



public class FireBall : MonoBehaviour {

	Transform gunTrans;

	AudioSource shoot;

	[SerializeField]
	GameObject bulletPrefab;

	[SerializeField]
	Transform bulletTrans;



	public static int fireBallCtr;

	// Use this for initialization
	void Start () {
		gunTrans = GetComponent<Transform> ();
		shoot = GetComponent<AudioSource>();
		fireBallCtr = 0;

	}

	// Update is called once per frame
	void Update () {

		if(Player.isFireFlower){


		if(Input.GetButtonDown("Fire1") && !UI.checkPause && fireBallCtr != 3)
		{
			
				SoundManager.fireball.Play ();
				Instantiate (bulletPrefab, bulletTrans.position, bulletTrans.rotation);
			fireBallCtr++;
			shoot.Play ();
		} 	
		}


	}

	void OnGUI()
	{
		//GUI.Label (new Rect (Screen.width -80, 0, 150, 20), "Bullets: " + bullet);
	}


}
