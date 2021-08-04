using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

	public static AudioSource levelmusic;

	bool checkOption;
	public static bool checkLevelClear;
	public static bool checkStart;
	public static bool checkEscape;
	public static bool checkPause;
	private GUIStyle guiStyle = new GUIStyle();


	// Use this for initialization
	void Start () {
//		checkLevelClear = false;
		levelmusic = GetComponent<AudioSource>();
		levelmusic.Play ();
	}

	// Update is called once per frame
	void Update () {

		if (checkPause) {
			Time.timeScale = 0;
		}


		if (!checkPause) {
			Time.timeScale = 1;
		}


	}

	void OnGUI()
	{
		 	if (checkStart) {
			guiStyle.fontSize = 30;
			GUI.Label (new Rect (10, 0, 300, 250), "Life: "+ Player.life, guiStyle);
			GUI.Label (new Rect (10, 40, 300, 250), "Score: " + Player.score, guiStyle);
			checkPause = false;
		

			if(Input.GetKey(KeyCode.Escape))
			{
				checkEscape = true;


			}
				
			if (checkEscape) {
				GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 35, 300, 150), "Back to Main Menu");
				checkPause = true;

				if (GUI.Button (new Rect (Screen.width / 2 - 120, Screen.height / 2 + 70, 100, 20), "No")) {
					checkEscape = false;
					checkPause = false;

				}

				if (GUI.Button (new Rect (Screen.width / 2 + 20, Screen.height / 2 + 70, 100, 20), "Yes")) {
					checkStart = false;
					checkEscape = false;
					Player.templife = 3;
					SceneManager.LoadScene (0);

				}


			}


			if (checkLevelClear) {
				GUI.Box (new Rect (Screen.width / 2 - 150, Screen.height / 2 - 125, 300, 150), "");


				GUI.Label (new Rect (Screen.width / 2 - 60, Screen.height / 2 - 100, 200, 40), "You finished the Level!");
				GUI.Label (new Rect (Screen.width / 2 - 30, Screen.height / 2 - 80, 200, 40), "Score: " + Player.score);

				if (GUI.Button (new Rect (Screen.width / 2 - 70, Screen.height / 2 - 20, 150, 40), "Back to Main Menu")) {
					Player.templife = 3;
					SceneManager.LoadScene (0);
					UI.checkStart = true;
					UI.checkLevelClear = false;
				}

//				if (GUI.Button (new Rect (Screen.width / 2 + 10, Screen.height / 2 - 50, 120, 40), "Continue")) {
//					//	SceneManager.LoadScene (1);
//				}
//
//				if (GUI.Button (new Rect (Screen.width / 2 - 130, Screen.height / 2 + 10, 120, 40), "Controls")) {
//					//	SceneManager.LoadScene (1);
//				}
//
//				if (GUI.Button (new Rect (Screen.width / 2 + 10, Screen.height / 2 + 10, 120, 40), "Exit")) {
//
//
//				}
//
				checkPause = true;


			}




		}



	}


}
