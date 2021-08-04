using UnityEngine;
using System.Collections;

public class HeadDetect : MonoBehaviour {

	GameObject Enemy;

	// Use this for initialization
	void Start () {

		Enemy = gameObject.transform.parent.gameObject;
	
	}
//
//	private void OnCollisionEnter(Collision col){
//
//		if (col.collider.tag == "Player") {
//		GetComponent<Collider>().enabled = false;
//		Enemy.GetComponent<Collider> ().enabled = false;
//		Vector3 movement = new Vector3 (Random.Range (40, 70), Random.Range (-40, 40), 0f);
//		Enemy.transform.position += movement * Time.deltaTime;
//
//		//Destroy(GameObject.Find("Goomba"));
//
//	}




	// Update is called once per frame
	void Update () {
	
	}
}
