using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float force = 1;

	public Transform playerTrans;

	public static int score;

	public float distToGround = 0.000001f;

	private BoxCollider boxCollider;

	public static bool isGrounded = false;

	public static bool isBig;
	public static bool isFireFlower;

	public static int life;
	public static int templife = 3;

	//public static bool knockback;
	//int knockdelay;

	float lr;

	GameObject PlayerObject;

	// Use this for initialization



	void Start () {
		playerTrans = GetComponent<Transform>();
		isBig = false;
		isFireFlower = false;
		life = templife;
		score = 0;
		PlayerObject = gameObject.transform.gameObject;
		SoundManager.lifelose.Play();

	}


	void FixedUpdate()
	{
		GroundCheck (); 
	}


	// Update is called once per frame
	void Update () {

		if (isBig) {
			transform.localScale = new Vector3 (1.1f, 1.1f, 1.1f);



		} else {
			transform.localScale = new Vector3 (0.5817691f, 0.5817691f, 0.5817691f);
			

		}

		if (life == 0) {
			SoundManager.gameover.Play ();
			SceneManager.LoadScene (2);



		}


//		if (knockback) {
//			lr = .1f;
//			playerTrans.Translate (0, 0, lr);
//
//			if(knockdelay > 20){
//				knockback = false;
//				knockdelay = 0;
//			}
//			knockdelay++;
//		}




		if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
		{
			SoundManager.Jump.Play ();


		}



		
	}

	void OnCollisionEnter(Collision col)
	{



		if (col.collider.tag == "Threat") {


			//knockbackbool

			//knockback = true;






			if (isBig && !isFireFlower && isGrounded) {
				isBig = false;
				SoundManager.playergothit.Play ();

			}

			else if (isFireFlower && isGrounded) {
				isFireFlower = false;
				SoundManager.playergothit.Play ();
			}

			else {

				if(!isFireFlower && !isBig && isGrounded){
					templife--;
					life--;

					SceneManager.LoadScene (1);
				}
				// Player.GetComponent<Collider> ().enabled = false;
			}


		} 
			






	}
//
//	void OnTriggerEnter(Collider other){
//		if (other.gameObject.tag == "Threat" ) {
//			Vector3 pushDirection = other.transform.position - transform.position;
//
//			pushDirection =- pushDirection.normalized;
//
//			GetComponent<Rigidbody> ().AddForce (pushDirection * force * 100);
//
//		}
//
//	}






	void GroundCheck(){
		if (Physics.Raycast (transform.position, Vector3.down, distToGround)) {
			isGrounded = true;

		} else {
			isGrounded = false;
		}

	}


}
