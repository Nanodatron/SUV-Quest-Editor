using UnityEngine;
using System.Collections;

public class btnQuestFinish : MonoBehaviour {

	private GameObject root;
	private GameObject header;
	private GameObject collisions;
	private GameObject character;
	private GameObject thisPage;
	private randomAudioPlayer _scriptRandomAudioPlayer;
	private Animation anim;
	public GameObject temoin;

	void Start()
	{
		root = transform.parent.parent.parent.gameObject; // pointe "ROOT"
		header = root.transform.Find("GUI/HEADER").gameObject; // pointe "HEADER"
		collisions = root.transform.Find("MOBILE_pos/STATUS_trm").gameObject; // pointe "Collisions"
		character = root.transform.Find("MOBILE_pos/character_scl/character_sprite").gameObject; // pointe "character_sprite"
		_scriptRandomAudioPlayer = character.GetComponent<randomAudioPlayer>();
		thisPage = transform.parent.gameObject; // pointe "page"
		anim = character.GetComponent<Animation>(); // cherche l'animation de "character"
	}

	public void Finish()
	{
		collisions.SetActive (true);
		_scriptRandomAudioPlayer.AudioPlayQuestFinish();
		anim.CrossFade ("action");
		header.SetActive(false);
		thisPage.SetActive (false);
		temoin.SetActive(true);
	}
}
