using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	[SerializeField]
	GameObject expPrefab;

	GameObject playerr;
	public Transform target;

	Rigidbody rig;
	Vector3 Position;


	public float speed;
	private float waitTime;
	public float startWaitTime;

	public Transform[] moveSpot;
	private int randomSpot;







	// Use this for initialization
	void Start () {

		playerr = GameObject.Find ("Player");
		target = playerr.transform;





		rig = GetComponent<Rigidbody> ();


		waitTime = startWaitTime;
		randomSpot = Random.Range (0, moveSpot.Length);




	}

	void FixedUpdate(){

//			Vector3 pos = Vector3.MoveTowards (transform.position, target.position, speed
//				* Time.fixedDeltaTime);
//
//			rig.MovePosition (pos);
//			transform.LookAt (target);

		Position = new Vector3 (transform.position.x, transform.position.y + 3f, transform.position.z);


	}

	void OnCollisionEnter(Collision col)
	{



		if (col.collider.tag == "Player") {
			if (!Player.isGrounded) {
				SoundManager.enemydeath.Play ();
				//Instantiate (expPrefab, GetComponent<Transform> ().position, Quaternion.identity);
				Instantiate (expPrefab, Position, Quaternion.identity);
				Player.score += 20;
				Destroy (gameObject);
			}
		}
			

			if (col.collider.tag == "B") {
			SoundManager.enemydeath.Play ();
			Instantiate (expPrefab, Position, Quaternion.identity);
			Player.score += 20;		
			Destroy (gameObject);
					
			}




		
			

	}

	// Update is called once per frame
	void Update () {

		transform.position = Vector3.MoveTowards (transform.position, moveSpot[randomSpot].position, speed * Time.deltaTime);
	
		if(Vector3.Distance(transform.position,moveSpot[randomSpot].position) < 0.2f){
				if(waitTime <= 0){
				randomSpot = Random.Range(0,moveSpot.Length);
					waitTime = startWaitTime;
				}
				else{
					waitTime = Time.deltaTime;
				}

			}
	
	}
}
