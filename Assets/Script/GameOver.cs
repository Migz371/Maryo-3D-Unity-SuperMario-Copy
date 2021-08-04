using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public static AudioSource lifelose;
	// Use this for initialization
	void Start () {
		lifelose = GetComponent<AudioSource>();
		lifelose.Play ();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{


			//display at the center of the screen
			GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 125, 300, 150), "GAME OVER");


			if (GUI.Button (new Rect (Screen.width / 2 - 110, Screen.height / 2 - 50, 220, 40), "Back to Main Menu")) {
				SceneManager.LoadScene (0);
			Player.templife = 3;




			//GUI.Label(new Rect(Screen.width, Screen.height, 200, 200), lblTexture);




		}



	}


}
