using UnityEngine;
using System.Collections;

public class btnClose : MonoBehaviour {

	private GameObject root;
	private GameObject header;
	private GameObject collisions;
	private GameObject character;
	private GameObject thisPage;
	private randomAudioPlayer _scriptRandomAudioPlayer;

	void Start()
	{
		root = transform.parent.parent.parent.gameObject; // pointe "ROOT"
		header = root.transform.Find("GUI/HEADER").gameObject; // pointe "HEADER"
		collisions = root.transform.Find ("MOBILE_pos/STATUS_trm").gameObject; // pointe "Collisions"
		character = root.transform.Find("MOBILE_pos/character_scl/character_sprite").gameObject; // pointe "character_sprite"
		_scriptRandomAudioPlayer = character.GetComponent<randomAudioPlayer>();
		thisPage = transform.parent.gameObject; // pointe "page"
	}

	public void Close()
	{
		collisions.SetActive (true);
		_scriptRandomAudioPlayer.RandomAudioPlayBye ();
		header.SetActive(false);
		thisPage.SetActive (false);
	}
}
