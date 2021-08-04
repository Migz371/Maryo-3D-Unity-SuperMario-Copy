using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public static AudioSource Jump;
	public static AudioSource breakblock;
	public static AudioSource coin;
	public static AudioSource powerupappear;
	public static AudioSource getpowerup;
	public static AudioSource pipeenter;
	public static AudioSource fireball;
	public static AudioSource enemydeath;
	public static AudioSource turretexplosion;
	public static AudioSource levelmusic;
	public static AudioSource gameover;
	public static AudioSource playergothit;
	public static AudioSource win;
	public static AudioSource lifelose;




	// Use this for initialization
	void Start () {
		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
		Jump = allMyAudioSources [0];
		breakblock = allMyAudioSources [1];
		coin = allMyAudioSources [2];
		powerupappear = allMyAudioSources [3];
		getpowerup = allMyAudioSources [4];
		pipeenter = allMyAudioSources [5];
		fireball = allMyAudioSources [6];
		enemydeath = allMyAudioSources [7];
		turretexplosion = allMyAudioSources [8];
		levelmusic = allMyAudioSources [9];
		gameover = allMyAudioSources [10];
		playergothit = allMyAudioSources [11];
		win = allMyAudioSources [12];
		lifelose = allMyAudioSources [13];


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
