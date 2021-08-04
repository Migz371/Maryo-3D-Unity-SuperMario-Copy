using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public static AudioSource MainMenu;

	bool checkStart;
	bool checkMain;
	bool checkControls;


	// Use this for initialization
	void Start () {
		MainMenu = GetComponent<AudioSource>();
		MainMenu.Play ();
		checkMain = true;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI()
	{

		if (!checkStart && checkMain) {

			//display at the center of the screen
			GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 125, 300, 160), "Main Menu");


			if (GUI.Button (new Rect (Screen.width / 2 - 130, Screen.height / 2 - 50, 120, 40), "Start")) {
				
				UI.checkStart = true;
				SceneManager.LoadScene (1);
			}

//			if (GUI.Button (new Rect (Screen.width / 2 + 10, Screen.height / 2 - 50, 120, 40), "Continue")) {
//				//	SceneManager.LoadScene (1);
//			}

			if (GUI.Button (new Rect (Screen.width / 2 + 10, Screen.height / 2 - 50, 120, 40), "Controls")) {
				checkControls = true;
				checkMain = false;
			}

//			if (GUI.Button (new Rect (Screen.width / 2 + 10, Screen.height / 2 + 10, 120, 40), "Exit")) {
//
//
//			}




			//GUI.Label(new Rect(Screen.width, Screen.height, 200, 200), lblTexture);




		} else if (checkControls) {
			GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 125, 300, 250), "Controls");

			GUI.Label (new Rect (Screen.width / 2 - 130, Screen.height / 2 - 80, 300, 40), "W A S D                              Movement Keys");
			GUI.Label (new Rect (Screen.width / 2 - 130, Screen.height / 2 - 50, 300, 40), "Spacebar                             Jump");
			GUI.Label (new Rect (Screen.width / 2 - 130, Screen.height / 2 - 20, 300, 40), "Left Mouse Button                 Fireball");

			if (GUI.Button (new Rect (Screen.width / 2 - 70, Screen.height / 2 + 30, 140, 40), "Back to Main Menu")) {
				checkControls = false;
				checkMain = true;


			}

		}



	}


}
